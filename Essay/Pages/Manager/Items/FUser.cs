﻿using Essay.Components;
using System;
using System.Linq;

namespace Essay.Pages.Items
{
    public partial class FUser : UserControl
    {
        Action<FUser> DeleteUser;
        /*
        [ID] varchar(50) Primary key,

            [Name] varchar(250),
	        [User] varchar(50) ,
	        [Pass] varchar(20) ,	
	        birthDay date,
            Phone varchar(10),
	        [Status] bit,	
	        isDelete bit,
            LinkAVT Text
        */

        public String ID;


        public FUser()
        {
            InitializeComponent();
            DeleteUser = null;
            ID = "001";
        }
        public FUser(Action<FUser> deleteU, string iD)
        {
            InitializeComponent();
            DeleteUser = deleteU;
            ID = iD;
            panel5.VerticalScroll.Visible = false;
            panel5.VerticalScroll.Enabled = false;
            panel5.HorizontalScroll.Visible = false;
            panel5.HorizontalScroll.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteUser(this);
        }
        private Color GenerateRandomColor()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            return randomColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            // pnID.BackColor = GenerateRandomColor();
            pnID.BackColor = Variables._Back_Items_User;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pnID.Location.X.ToString() + "; y= " + pnID.Location.X.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
