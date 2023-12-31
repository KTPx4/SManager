﻿using DevExpress.Mvvm.Native;
using Essay.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Essay.Controllers
{
    public class AdminController
    {

        private static EssayDBDataContext db ;
        
        public AdminController() 
        {
            db = new EssayDBDataContext();
        }

        public  Admin GetFromUser(string username)
        {
            return db.Admins.SingleOrDefault(e => e.User == username);
        }

        public  int ValidLogin(string username, string password)
        {
            int CountAdmin = (from Ad in db.Admins
                              where Ad.User == username && Ad.Password == password 
                              select Ad.User).ToList().Count();
            if (CountAdmin > 0) return 2; // admin

            int CountManager = (from Ad in db.Managers
                              where Ad.User == username && Ad.Pass == password && Ad.Status == 0
                              select Ad.User).ToList().Count();
            if (CountManager > 0) return 0; // manager

            int CountEmp = (from Ad in db.Employees
                                where Ad.User == username && Ad.Pass == password && Ad.Status == 0
                            select Ad.User).ToList().Count();
            if (CountEmp > 0) return 1; // employee


            // Account block or deleted
            int CountManagers = (from Ad in db.Managers
                                where Ad.User == username && Ad.Pass == password && Ad.Status != 0
                                select Ad.User).ToList().Count();
            if (CountManagers > 0) return -10; // manager block or deleted

            int CountEmps = (from Ad in db.Employees
                            where Ad.User == username && Ad.Pass == password && Ad.Status != 0
                            select Ad.User).ToList().Count();
            if (CountEmps > 0) return -11; // employee block or deleted

            return -1; // not found

        }

        public  int NextID()
        {


            var currentID = (from em in db.Admins
                             orderby em.ID descending
                             select em.ID).FirstOrDefault();

            //int id = int.Parse(currentID.ToString());
            // MessageBox.Show("" + currentID);

            return int.Parse(currentID.ToString()) + 1;
        }

        // check is Exists From 3 table

        public  bool isExistsUser(string username)
        {

            //MessageBox.Show("user count: " + CountUser.ToString());

            if (isExistsAdmin(username) || new ManagerController().isExistsUser(username) || new EmployeeController().isExistsUser(username))
            {
                return true;
            }

            return false;

        }


        // check is Exists from each table

        public  bool isExistsEmployee(string username) // table employee
        {
            return new EmployeeController().isExistsUser(username);
        }

        public  bool isExistsManager(string username) // table Manager
        {
            return new ManagerController().isExistsUser(username);
        }

        public  bool isExistsAdmin(string username)  // table Admin
        {
            int CountAdmin = (from Ad in db.Admins
                              where Ad.User == username
                              select Ad.User).ToList().Count();
            return CountAdmin > 0;
        }       


        // Delete from User Name
        public  bool DeleteUser(String  username)
        {
            if (new EmployeeController().Delete(username)) return true;
            else if (new ManagerController().Delete(username)) return true;

            return false;
        }


        //Edit user
        public  bool Update(Admin Admin)
        {


            // Tìm bản ghi Manager cần chỉnh sửa bằng User
            Admin existingAdmin = db.Admins.SingleOrDefault(m => m.ID == Admin.ID);

            if (existingAdmin != null)
            {
                // Thực hiện các thay đổi cần thiết trên bản ghi Manager
                existingAdmin.Name = Admin.Name;
                existingAdmin.Password = Admin.Password;                
               // existingAdmin.LinkAVT = Admin.LinkAVT;
                existingAdmin.User = Admin.User;

                // if change user -> check exists with other row
                //    MessageBox.Show("db: " + existingEmployee.User + ", :" + Employee.User);
                if (existingAdmin.User != Admin.User && new AdminController().isExistsUser(Admin.User))
                {
                    MessageBox.Show("User Name is invalid", "Error Input", MessageBoxButtons.OK);
                    return false;
                }
                else if (existingAdmin.User != Admin.User && ! new AdminController().isExistsUser(Admin.User))
                {
                    existingAdmin.User = Admin.User;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }

            return false; // Bản ghi không tồn tại hoặc không tìm thấy
        }

        // Lock Account from User Name
        public  bool LockUser(String username)
        {
            if (new EmployeeController().Lock(username)) return true;
            else if (new ManagerController().Lock(username)) return true;
            return false;
        }

        public  bool RestoreUser(String username)
        {
            if (new EmployeeController().Restore(username)) return true;
            else if (new ManagerController().Restore(username)) return true;

            return false;
        }

        public  bool SetisOnline(String username, bool Status)
        {
            if (new EmployeeController().SetisOnline(username, Status)) return true;
            else if (new ManagerController().SetisOnline(username, Status)) return true;

            return false;
        }
        
        // Find from search
        public  Tuple<List<Manager>, List<Employee>> Search(String search)
        {           

            // Tìm các bản ghi trong bảng Manager thỏa mãn điều kiện tìm kiếm
            List<Manager> managerResults = db.Managers
                .Where(m => m.Name.Contains(search) || m.User.Contains(search) || m.Phone.Contains(search))
                .ToList();

            // Tìm các bản ghi trong bảng Employee thỏa mãn điều kiện tìm kiếm
            List<Employee> employeeResults = db.Employees
                .Where(e => e.Name.Contains(search) || e.User.Contains(search) || e.Phone.Contains(search))
                .ToList();

            Tuple<List<Manager>, List<Employee>> Result = new Tuple<List<Manager>, List<Employee>>(managerResults, employeeResults);
            
            return Result;
        }
    }
}
