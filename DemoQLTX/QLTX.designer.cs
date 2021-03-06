#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoQLKS
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ql")]
	public partial class QLTXDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLichSuDangNhap(LichSuDangNhap instance);
    partial void UpdateLichSuDangNhap(LichSuDangNhap instance);
    partial void DeleteLichSuDangNhap(LichSuDangNhap instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertTTXeDangThue(TTXeDangThue instance);
    partial void UpdateTTXeDangThue(TTXeDangThue instance);
    partial void DeleteTTXeDangThue(TTXeDangThue instance);
    partial void InsertXe(Xe instance);
    partial void UpdateXe(Xe instance);
    partial void DeleteXe(Xe instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    #endregion
		
		public QLTXDataContext() : 
				base(global::DemoQLKS.Properties.Settings.Default.qlConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLTXDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTXDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTXDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTXDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LichSuDangNhap> LichSuDangNhaps
		{
			get
			{
				return this.GetTable<LichSuDangNhap>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<TTXeDangThue> TTXeDangThues
		{
			get
			{
				return this.GetTable<TTXeDangThue>();
			}
		}
		
		public System.Data.Linq.Table<Xe> Xes
		{
			get
			{
				return this.GetTable<Xe>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getNVByID")]
		public ISingleResult<getNVByIDResult> getNVByID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<getNVByIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xoaNhanVien")]
		public int xoaNhanVien([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CMND;
		
		private string _Name;
		
		private string _Phone;
		
		private string _Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public KhachHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichSuDangNhap")]
	public partial class LichSuDangNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idLogin;
		
		private int _idNhanVien;
		
		private System.Nullable<System.DateTime> _TimeLogin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLoginChanging(int value);
    partial void OnidLoginChanged();
    partial void OnidNhanVienChanging(int value);
    partial void OnidNhanVienChanged();
    partial void OnTimeLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeLoginChanged();
    #endregion
		
		public LichSuDangNhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLogin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idLogin
		{
			get
			{
				return this._idLogin;
			}
			set
			{
				if ((this._idLogin != value))
				{
					this.OnidLoginChanging(value);
					this.SendPropertyChanging();
					this._idLogin = value;
					this.SendPropertyChanged("idLogin");
					this.OnidLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idNhanVien", DbType="Int NOT NULL")]
		public int idNhanVien
		{
			get
			{
				return this._idNhanVien;
			}
			set
			{
				if ((this._idNhanVien != value))
				{
					this.OnidNhanVienChanging(value);
					this.SendPropertyChanging();
					this._idNhanVien = value;
					this.SendPropertyChanged("idNhanVien");
					this.OnidNhanVienChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.DateTime _DoB;
		
		private string _Phone;
		
		private string _Sex;
		
		private string _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDoBChanging(System.DateTime value);
    partial void OnDoBChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public NhanVien()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoB", DbType="DateTime NOT NULL")]
		public System.DateTime DoB
		{
			get
			{
				return this._DoB;
			}
			set
			{
				if ((this._DoB != value))
				{
					this.OnDoBChanging(value);
					this.SendPropertyChanging();
					this._DoB = value;
					this.SendPropertyChanged("DoB");
					this.OnDoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NChar(10)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NChar(20)")]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TTXeDangThue")]
	public partial class TTXeDangThue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _idXe;
		
		private string _CMND;
		
		private string _TênKH;
		
		private System.Nullable<System.DateTime> _TimeStart;
		
		private System.Nullable<int> _SoNguoi;
		
		private System.Nullable<int> _ThoiGianThue;
		
		private System.Nullable<int> _PhuThuCheckIn;
		
		private System.Nullable<int> _PhuThuCheckOut;
		
		private System.Nullable<int> _GiaXe;
		
		private System.Nullable<int> _PhuThuThem;
		
		private System.Nullable<int> _Total;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnidXeChanging(System.Nullable<int> value);
    partial void OnidXeChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnTênKHChanging(string value);
    partial void OnTênKHChanged();
    partial void OnTimeStartChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeStartChanged();
    partial void OnSoNguoiChanging(System.Nullable<int> value);
    partial void OnSoNguoiChanged();
    partial void OnThoiGianThueChanging(System.Nullable<int> value);
    partial void OnThoiGianThueChanged();
    partial void OnPhuThuCheckInChanging(System.Nullable<int> value);
    partial void OnPhuThuCheckInChanged();
    partial void OnPhuThuCheckOutChanging(System.Nullable<int> value);
    partial void OnPhuThuCheckOutChanged();
    partial void OnGiaXeChanging(System.Nullable<int> value);
    partial void OnGiaXeChanged();
    partial void OnPhuThuThemChanging(System.Nullable<int> value);
    partial void OnPhuThuThemChanged();
    partial void OnTotalChanging(System.Nullable<int> value);
    partial void OnTotalChanged();
    #endregion
		
		public TTXeDangThue()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idXe", DbType="Int")]
		public System.Nullable<int> idXe
		{
			get
			{
				return this._idXe;
			}
			set
			{
				if ((this._idXe != value))
				{
					this.OnidXeChanging(value);
					this.SendPropertyChanging();
					this._idXe = value;
					this.SendPropertyChanged("idXe");
					this.OnidXeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(10)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TênKH", DbType="NVarChar(20)")]
		public string TênKH
		{
			get
			{
				return this._TênKH;
			}
			set
			{
				if ((this._TênKH != value))
				{
					this.OnTênKHChanging(value);
					this.SendPropertyChanging();
					this._TênKH = value;
					this.SendPropertyChanged("TênKH");
					this.OnTênKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStart", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeStart
		{
			get
			{
				return this._TimeStart;
			}
			set
			{
				if ((this._TimeStart != value))
				{
					this.OnTimeStartChanging(value);
					this.SendPropertyChanging();
					this._TimeStart = value;
					this.SendPropertyChanged("TimeStart");
					this.OnTimeStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNguoi", DbType="Int")]
		public System.Nullable<int> SoNguoi
		{
			get
			{
				return this._SoNguoi;
			}
			set
			{
				if ((this._SoNguoi != value))
				{
					this.OnSoNguoiChanging(value);
					this.SendPropertyChanging();
					this._SoNguoi = value;
					this.SendPropertyChanged("SoNguoi");
					this.OnSoNguoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiGianThue", DbType="Int")]
		public System.Nullable<int> ThoiGianThue
		{
			get
			{
				return this._ThoiGianThue;
			}
			set
			{
				if ((this._ThoiGianThue != value))
				{
					this.OnThoiGianThueChanging(value);
					this.SendPropertyChanging();
					this._ThoiGianThue = value;
					this.SendPropertyChanged("ThoiGianThue");
					this.OnThoiGianThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThuCheckIn", DbType="Int")]
		public System.Nullable<int> PhuThuCheckIn
		{
			get
			{
				return this._PhuThuCheckIn;
			}
			set
			{
				if ((this._PhuThuCheckIn != value))
				{
					this.OnPhuThuCheckInChanging(value);
					this.SendPropertyChanging();
					this._PhuThuCheckIn = value;
					this.SendPropertyChanged("PhuThuCheckIn");
					this.OnPhuThuCheckInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThuCheckOut", DbType="Int")]
		public System.Nullable<int> PhuThuCheckOut
		{
			get
			{
				return this._PhuThuCheckOut;
			}
			set
			{
				if ((this._PhuThuCheckOut != value))
				{
					this.OnPhuThuCheckOutChanging(value);
					this.SendPropertyChanging();
					this._PhuThuCheckOut = value;
					this.SendPropertyChanged("PhuThuCheckOut");
					this.OnPhuThuCheckOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaXe", DbType="Int")]
		public System.Nullable<int> GiaXe
		{
			get
			{
				return this._GiaXe;
			}
			set
			{
				if ((this._GiaXe != value))
				{
					this.OnGiaXeChanging(value);
					this.SendPropertyChanging();
					this._GiaXe = value;
					this.SendPropertyChanged("GiaXe");
					this.OnGiaXeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThuThem", DbType="Int")]
		public System.Nullable<int> PhuThuThem
		{
			get
			{
				return this._PhuThuThem;
			}
			set
			{
				if ((this._PhuThuThem != value))
				{
					this.OnPhuThuThemChanging(value);
					this.SendPropertyChanging();
					this._PhuThuThem = value;
					this.SendPropertyChanged("PhuThuThem");
					this.OnPhuThuThemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Int")]
		public System.Nullable<int> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Xe")]
	public partial class Xe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Capacity;
		
		private string _Status;
		
		private System.Nullable<int> _Price;
		
		private string _Model;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCapacityChanging(System.Nullable<int> value);
    partial void OnCapacityChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    #endregion
		
		public Xe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capacity", DbType="Int")]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._Capacity;
			}
			set
			{
				if ((this._Capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._Capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(20)")]
		public string Status
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NChar(20)")]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idHoadon;
		
		private int _idXe;
		
		private string _TenKH;
		
		private string _CMND;
		
		private System.Nullable<System.DateTime> _NgayLapHD;
		
		private System.Nullable<int> _PhuThuCI;
		
		private System.Nullable<int> _PhuThuCO;
		
		private System.Nullable<int> _GiaPhongNiemYet;
		
		private System.Nullable<int> _SoNgayThue;
		
		private System.Nullable<int> _PhuThu;
		
		private System.Nullable<int> _TongCong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidHoadonChanging(int value);
    partial void OnidHoadonChanged();
    partial void OnidXeChanging(int value);
    partial void OnidXeChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnNgayLapHDChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapHDChanged();
    partial void OnPhuThuCIChanging(System.Nullable<int> value);
    partial void OnPhuThuCIChanged();
    partial void OnPhuThuCOChanging(System.Nullable<int> value);
    partial void OnPhuThuCOChanged();
    partial void OnGiaPhongNiemYetChanging(System.Nullable<int> value);
    partial void OnGiaPhongNiemYetChanged();
    partial void OnSoNgayThueChanging(System.Nullable<int> value);
    partial void OnSoNgayThueChanged();
    partial void OnPhuThuChanging(System.Nullable<int> value);
    partial void OnPhuThuChanged();
    partial void OnTongCongChanging(System.Nullable<int> value);
    partial void OnTongCongChanged();
    #endregion
		
		public HoaDon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idHoadon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idHoadon
		{
			get
			{
				return this._idHoadon;
			}
			set
			{
				if ((this._idHoadon != value))
				{
					this.OnidHoadonChanging(value);
					this.SendPropertyChanging();
					this._idHoadon = value;
					this.SendPropertyChanged("idHoadon");
					this.OnidHoadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="idPhong", Storage="_idXe", DbType="Int NOT NULL")]
		public int idXe
		{
			get
			{
				return this._idXe;
			}
			set
			{
				if ((this._idXe != value))
				{
					this.OnidXeChanging(value);
					this.SendPropertyChanging();
					this._idXe = value;
					this.SendPropertyChanged("idXe");
					this.OnidXeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLapHD", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayLapHD
		{
			get
			{
				return this._NgayLapHD;
			}
			set
			{
				if ((this._NgayLapHD != value))
				{
					this.OnNgayLapHDChanging(value);
					this.SendPropertyChanging();
					this._NgayLapHD = value;
					this.SendPropertyChanged("NgayLapHD");
					this.OnNgayLapHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThuCI", DbType="Int")]
		public System.Nullable<int> PhuThuCI
		{
			get
			{
				return this._PhuThuCI;
			}
			set
			{
				if ((this._PhuThuCI != value))
				{
					this.OnPhuThuCIChanging(value);
					this.SendPropertyChanging();
					this._PhuThuCI = value;
					this.SendPropertyChanged("PhuThuCI");
					this.OnPhuThuCIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThuCO", DbType="Int")]
		public System.Nullable<int> PhuThuCO
		{
			get
			{
				return this._PhuThuCO;
			}
			set
			{
				if ((this._PhuThuCO != value))
				{
					this.OnPhuThuCOChanging(value);
					this.SendPropertyChanging();
					this._PhuThuCO = value;
					this.SendPropertyChanged("PhuThuCO");
					this.OnPhuThuCOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaPhongNiemYet", DbType="Int")]
		public System.Nullable<int> GiaPhongNiemYet
		{
			get
			{
				return this._GiaPhongNiemYet;
			}
			set
			{
				if ((this._GiaPhongNiemYet != value))
				{
					this.OnGiaPhongNiemYetChanging(value);
					this.SendPropertyChanging();
					this._GiaPhongNiemYet = value;
					this.SendPropertyChanged("GiaPhongNiemYet");
					this.OnGiaPhongNiemYetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNgayThue", DbType="Int")]
		public System.Nullable<int> SoNgayThue
		{
			get
			{
				return this._SoNgayThue;
			}
			set
			{
				if ((this._SoNgayThue != value))
				{
					this.OnSoNgayThueChanging(value);
					this.SendPropertyChanging();
					this._SoNgayThue = value;
					this.SendPropertyChanged("SoNgayThue");
					this.OnSoNgayThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuThu", DbType="Int")]
		public System.Nullable<int> PhuThu
		{
			get
			{
				return this._PhuThu;
			}
			set
			{
				if ((this._PhuThu != value))
				{
					this.OnPhuThuChanging(value);
					this.SendPropertyChanging();
					this._PhuThu = value;
					this.SendPropertyChanged("PhuThu");
					this.OnPhuThuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongCong", DbType="Int")]
		public System.Nullable<int> TongCong
		{
			get
			{
				return this._TongCong;
			}
			set
			{
				if ((this._TongCong != value))
				{
					this.OnTongCongChanging(value);
					this.SendPropertyChanging();
					this._TongCong = value;
					this.SendPropertyChanged("TongCong");
					this.OnTongCongChanged();
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
	
	public partial class getNVByIDResult
	{
		
		private int _ID;
		
		private string _Name;
		
		private System.DateTime _DoB;
		
		private string _Phone;
		
		private string _Sex;
		
		private string _Role;
		
		public getNVByIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoB", DbType="DateTime NOT NULL")]
		public System.DateTime DoB
		{
			get
			{
				return this._DoB;
			}
			set
			{
				if ((this._DoB != value))
				{
					this._DoB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(10)")]
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
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NChar(10)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this._Sex = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NChar(20)")]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this._Role = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
