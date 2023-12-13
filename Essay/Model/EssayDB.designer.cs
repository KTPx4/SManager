﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Essay.Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Essay")]
	public partial class EssayDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertCertification(Certification instance);
    partial void UpdateCertification(Certification instance);
    partial void DeleteCertification(Certification instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertHistoryEmployee(HistoryEmployee instance);
    partial void UpdateHistoryEmployee(HistoryEmployee instance);
    partial void DeleteHistoryEmployee(HistoryEmployee instance);
    partial void InsertHistoryManager(HistoryManager instance);
    partial void UpdateHistoryManager(HistoryManager instance);
    partial void DeleteHistoryManager(HistoryManager instance);
    partial void InsertManager(Manager instance);
    partial void UpdateManager(Manager instance);
    partial void DeleteManager(Manager instance);
    #endregion
		
		public EssayDBDataContext() : 
				base(global::Essay.Properties.Settings.Default.EssayConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public EssayDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EssayDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EssayDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EssayDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Certification> Certifications
		{
			get
			{
				return this.GetTable<Certification>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<HistoryEmployee> HistoryEmployees
		{
			get
			{
				return this.GetTable<HistoryEmployee>();
			}
		}
		
		public System.Data.Linq.Table<HistoryManager> HistoryManagers
		{
			get
			{
				return this.GetTable<HistoryManager>();
			}
		}
		
		public System.Data.Linq.Table<Manager> Managers
		{
			get
			{
				return this.GetTable<Manager>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _User;
		
		private string _Password;
		
		private string _Name;
		
		private string _LinkAVT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLinkAVTChanging(string value);
    partial void OnLinkAVTChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="VarChar(250)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(250)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAVT", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string LinkAVT
		{
			get
			{
				return this._LinkAVT;
			}
			set
			{
				if ((this._LinkAVT != value))
				{
					this.OnLinkAVTChanging(value);
					this.SendPropertyChanging();
					this._LinkAVT = value;
					this.SendPropertyChanged("LinkAVT");
					this.OnLinkAVTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SID;
		
		private string _Name;
		
		private string _Class;
		
		private System.Nullable<System.DateTime> _birthDay;
		
		private string _Address;
		
		private string _Phone;
		
		private EntitySet<Certification> _Certifications;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSIDChanging(string value);
    partial void OnSIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    partial void OnbirthDayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthDayChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Student()
		{
			this._Certifications = new EntitySet<Certification>(new Action<Certification>(this.attach_Certifications), new Action<Certification>(this.detach_Certifications));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="VarChar(250)")]
		public string SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="VarChar(250)")]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDay", DbType="Date")]
		public System.Nullable<System.DateTime> birthDay
		{
			get
			{
				return this._birthDay;
			}
			set
			{
				if ((this._birthDay != value))
				{
					this.OnbirthDayChanging(value);
					this.SendPropertyChanging();
					this._birthDay = value;
					this.SendPropertyChanged("birthDay");
					this.OnbirthDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(250)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Certification", Storage="_Certifications", ThisKey="SID", OtherKey="SID")]
		public EntitySet<Certification> Certifications
		{
			get
			{
				return this._Certifications;
			}
			set
			{
				this._Certifications.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Certifications(Certification entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Certifications(Certification entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Certification")]
	public partial class Certification : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDCertificate;
		
		private string _Name;
		
		private string _SID;
		
		private System.Nullable<System.DateTime> _IssueDate;
		
		private System.Nullable<System.DateTime> _ExpiryDate;
		
		private string _Grade;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCertificateChanging(string value);
    partial void OnIDCertificateChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSIDChanging(string value);
    partial void OnSIDChanged();
    partial void OnIssueDateChanging(System.Nullable<System.DateTime> value);
    partial void OnIssueDateChanged();
    partial void OnExpiryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnExpiryDateChanged();
    partial void OnGradeChanging(string value);
    partial void OnGradeChanged();
    #endregion
		
		public Certification()
		{
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCertificate", DbType="VarChar(250) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDCertificate
		{
			get
			{
				return this._IDCertificate;
			}
			set
			{
				if ((this._IDCertificate != value))
				{
					this.OnIDCertificateChanging(value);
					this.SendPropertyChanging();
					this._IDCertificate = value;
					this.SendPropertyChanged("IDCertificate");
					this.OnIDCertificateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="VarChar(250)")]
		public string SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueDate", DbType="Date")]
		public System.Nullable<System.DateTime> IssueDate
		{
			get
			{
				return this._IssueDate;
			}
			set
			{
				if ((this._IssueDate != value))
				{
					this.OnIssueDateChanging(value);
					this.SendPropertyChanging();
					this._IssueDate = value;
					this.SendPropertyChanged("IssueDate");
					this.OnIssueDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiryDate", DbType="Date")]
		public System.Nullable<System.DateTime> ExpiryDate
		{
			get
			{
				return this._ExpiryDate;
			}
			set
			{
				if ((this._ExpiryDate != value))
				{
					this.OnExpiryDateChanging(value);
					this.SendPropertyChanging();
					this._ExpiryDate = value;
					this.SendPropertyChanged("ExpiryDate");
					this.OnExpiryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grade", DbType="VarChar(50)")]
		public string Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this.OnGradeChanging(value);
					this.SendPropertyChanging();
					this._Grade = value;
					this.SendPropertyChanged("Grade");
					this.OnGradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Certification", Storage="_Student", ThisKey="SID", OtherKey="SID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Certifications.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Certifications.Add(this);
						this._SID = value.SID;
					}
					else
					{
						this._SID = default(string);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _User;
		
		private string _Pass;
		
		private System.Nullable<System.DateTime> _birthDay;
		
		private string _Phone;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<bool> _isOnline;
		
		private string _LinkAVT;
		
		private EntitySet<HistoryEmployee> _HistoryEmployees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnbirthDayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthDayChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnisOnlineChanging(System.Nullable<bool> value);
    partial void OnisOnlineChanged();
    partial void OnLinkAVTChanging(string value);
    partial void OnLinkAVTChanged();
    #endregion
		
		public Employee()
		{
			this._HistoryEmployees = new EntitySet<HistoryEmployee>(new Action<HistoryEmployee>(this.attach_HistoryEmployees), new Action<HistoryEmployee>(this.detach_HistoryEmployees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="VarChar(250)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(250)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDay", DbType="Date")]
		public System.Nullable<System.DateTime> birthDay
		{
			get
			{
				return this._birthDay;
			}
			set
			{
				if ((this._birthDay != value))
				{
					this.OnbirthDayChanging(value);
					this.SendPropertyChanging();
					this._birthDay = value;
					this.SendPropertyChanged("birthDay");
					this.OnbirthDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(250)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isOnline", DbType="Bit")]
		public System.Nullable<bool> isOnline
		{
			get
			{
				return this._isOnline;
			}
			set
			{
				if ((this._isOnline != value))
				{
					this.OnisOnlineChanging(value);
					this.SendPropertyChanging();
					this._isOnline = value;
					this.SendPropertyChanged("isOnline");
					this.OnisOnlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAVT", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string LinkAVT
		{
			get
			{
				return this._LinkAVT;
			}
			set
			{
				if ((this._LinkAVT != value))
				{
					this.OnLinkAVTChanging(value);
					this.SendPropertyChanging();
					this._LinkAVT = value;
					this.SendPropertyChanged("LinkAVT");
					this.OnLinkAVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_HistoryEmployee", Storage="_HistoryEmployees", ThisKey="ID", OtherKey="ID")]
		public EntitySet<HistoryEmployee> HistoryEmployees
		{
			get
			{
				return this._HistoryEmployees;
			}
			set
			{
				this._HistoryEmployees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HistoryEmployees(HistoryEmployee entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_HistoryEmployees(HistoryEmployee entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HistoryEmployee")]
	public partial class HistoryEmployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDLogin;
		
		private System.Nullable<int> _ID;
		
		private System.Nullable<System.DateTime> _TimeLogin;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLoginChanging(int value);
    partial void OnIDLoginChanged();
    partial void OnIDChanging(System.Nullable<int> value);
    partial void OnIDChanged();
    partial void OnTimeLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeLoginChanged();
    #endregion
		
		public HistoryEmployee()
		{
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLogin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDLogin
		{
			get
			{
				return this._IDLogin;
			}
			set
			{
				if ((this._IDLogin != value))
				{
					this.OnIDLoginChanging(value);
					this.SendPropertyChanging();
					this._IDLogin = value;
					this.SendPropertyChanged("IDLogin");
					this.OnIDLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeLogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeLogin
		{
			get
			{
				return this._TimeLogin;
			}
			set
			{
				if ((this._TimeLogin != value))
				{
					this.OnTimeLoginChanging(value);
					this.SendPropertyChanging();
					this._TimeLogin = value;
					this.SendPropertyChanged("TimeLogin");
					this.OnTimeLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_HistoryEmployee", Storage="_Employee", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.HistoryEmployees.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.HistoryEmployees.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HistoryManager")]
	public partial class HistoryManager : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDLogin;
		
		private System.Nullable<int> _ID;
		
		private System.Nullable<System.DateTime> _TimeLogin;
		
		private EntityRef<Manager> _Manager;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLoginChanging(int value);
    partial void OnIDLoginChanged();
    partial void OnIDChanging(System.Nullable<int> value);
    partial void OnIDChanged();
    partial void OnTimeLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeLoginChanged();
    #endregion
		
		public HistoryManager()
		{
			this._Manager = default(EntityRef<Manager>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLogin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDLogin
		{
			get
			{
				return this._IDLogin;
			}
			set
			{
				if ((this._IDLogin != value))
				{
					this.OnIDLoginChanging(value);
					this.SendPropertyChanging();
					this._IDLogin = value;
					this.SendPropertyChanged("IDLogin");
					this.OnIDLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Manager.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeLogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeLogin
		{
			get
			{
				return this._TimeLogin;
			}
			set
			{
				if ((this._TimeLogin != value))
				{
					this.OnTimeLoginChanging(value);
					this.SendPropertyChanging();
					this._TimeLogin = value;
					this.SendPropertyChanged("TimeLogin");
					this.OnTimeLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manager_HistoryManager", Storage="_Manager", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Manager Manager
		{
			get
			{
				return this._Manager.Entity;
			}
			set
			{
				Manager previousValue = this._Manager.Entity;
				if (((previousValue != value) 
							|| (this._Manager.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Manager.Entity = null;
						previousValue.HistoryManagers.Remove(this);
					}
					this._Manager.Entity = value;
					if ((value != null))
					{
						value.HistoryManagers.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Manager");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manager")]
	public partial class Manager : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _User;
		
		private string _Pass;
		
		private System.Nullable<System.DateTime> _birthDay;
		
		private string _Phone;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<bool> _isOnline;
		
		private string _LinkAVT;
		
		private EntitySet<HistoryManager> _HistoryManagers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnbirthDayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthDayChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnisOnlineChanging(System.Nullable<bool> value);
    partial void OnisOnlineChanged();
    partial void OnLinkAVTChanging(string value);
    partial void OnLinkAVTChanged();
    #endregion
		
		public Manager()
		{
			this._HistoryManagers = new EntitySet<HistoryManager>(new Action<HistoryManager>(this.attach_HistoryManagers), new Action<HistoryManager>(this.detach_HistoryManagers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="VarChar(250)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(250)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDay", DbType="Date")]
		public System.Nullable<System.DateTime> birthDay
		{
			get
			{
				return this._birthDay;
			}
			set
			{
				if ((this._birthDay != value))
				{
					this.OnbirthDayChanging(value);
					this.SendPropertyChanging();
					this._birthDay = value;
					this.SendPropertyChanged("birthDay");
					this.OnbirthDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(250)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isOnline", DbType="Bit")]
		public System.Nullable<bool> isOnline
		{
			get
			{
				return this._isOnline;
			}
			set
			{
				if ((this._isOnline != value))
				{
					this.OnisOnlineChanging(value);
					this.SendPropertyChanging();
					this._isOnline = value;
					this.SendPropertyChanged("isOnline");
					this.OnisOnlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAVT", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string LinkAVT
		{
			get
			{
				return this._LinkAVT;
			}
			set
			{
				if ((this._LinkAVT != value))
				{
					this.OnLinkAVTChanging(value);
					this.SendPropertyChanging();
					this._LinkAVT = value;
					this.SendPropertyChanged("LinkAVT");
					this.OnLinkAVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manager_HistoryManager", Storage="_HistoryManagers", ThisKey="ID", OtherKey="ID")]
		public EntitySet<HistoryManager> HistoryManagers
		{
			get
			{
				return this._HistoryManagers;
			}
			set
			{
				this._HistoryManagers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HistoryManagers(HistoryManager entity)
		{
			this.SendPropertyChanging();
			entity.Manager = this;
		}
		
		private void detach_HistoryManagers(HistoryManager entity)
		{
			this.SendPropertyChanging();
			entity.Manager = null;
		}
	}
}
#pragma warning restore 1591
