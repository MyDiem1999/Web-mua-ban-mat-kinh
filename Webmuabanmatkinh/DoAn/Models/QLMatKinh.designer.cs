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

namespace DoAn.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSanPham")]
	public partial class QLMatKinhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_ChiTietHD(tbl_ChiTietHD instance);
    partial void Updatetbl_ChiTietHD(tbl_ChiTietHD instance);
    partial void Deletetbl_ChiTietHD(tbl_ChiTietHD instance);
    partial void Inserttbl_HoaDon(tbl_HoaDon instance);
    partial void Updatetbl_HoaDon(tbl_HoaDon instance);
    partial void Deletetbl_HoaDon(tbl_HoaDon instance);
    partial void Inserttbl_KhachHang(tbl_KhachHang instance);
    partial void Updatetbl_KhachHang(tbl_KhachHang instance);
    partial void Deletetbl_KhachHang(tbl_KhachHang instance);
    partial void Inserttbl_Loai(tbl_Loai instance);
    partial void Updatetbl_Loai(tbl_Loai instance);
    partial void Deletetbl_Loai(tbl_Loai instance);
    partial void Inserttbl_NhaSanXuat(tbl_NhaSanXuat instance);
    partial void Updatetbl_NhaSanXuat(tbl_NhaSanXuat instance);
    partial void Deletetbl_NhaSanXuat(tbl_NhaSanXuat instance);
    partial void Inserttbl_Nhom(tbl_Nhom instance);
    partial void Updatetbl_Nhom(tbl_Nhom instance);
    partial void Deletetbl_Nhom(tbl_Nhom instance);
    partial void Inserttbl_SanPham(tbl_SanPham instance);
    partial void Updatetbl_SanPham(tbl_SanPham instance);
    partial void Deletetbl_SanPham(tbl_SanPham instance);
    #endregion
		
		public QLMatKinhDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLSanPhamConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLMatKinhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMatKinhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMatKinhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMatKinhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_ChiTietHD> tbl_ChiTietHDs
		{
			get
			{
				return this.GetTable<tbl_ChiTietHD>();
			}
		}
		
		public System.Data.Linq.Table<tbl_HoaDon> tbl_HoaDons
		{
			get
			{
				return this.GetTable<tbl_HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<tbl_KhachHang> tbl_KhachHangs
		{
			get
			{
				return this.GetTable<tbl_KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Loai> tbl_Loais
		{
			get
			{
				return this.GetTable<tbl_Loai>();
			}
		}
		
		public System.Data.Linq.Table<tbl_NhaSanXuat> tbl_NhaSanXuats
		{
			get
			{
				return this.GetTable<tbl_NhaSanXuat>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Nhom> tbl_Nhoms
		{
			get
			{
				return this.GetTable<tbl_Nhom>();
			}
		}
		
		public System.Data.Linq.Table<tbl_SanPham> tbl_SanPhams
		{
			get
			{
				return this.GetTable<tbl_SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_ChiTietHD")]
	public partial class tbl_ChiTietHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private string _MaSP;
		
		private System.Nullable<int> _SoLuong;
		
		private EntityRef<tbl_HoaDon> _tbl_HoaDon;
		
		private EntityRef<tbl_SanPham> _tbl_SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaSPChanging(string value);
    partial void OnMaSPChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    #endregion
		
		public tbl_ChiTietHD()
		{
			this._tbl_HoaDon = default(EntityRef<tbl_HoaDon>);
			this._tbl_SanPham = default(EntityRef<tbl_SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._tbl_HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._tbl_SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_HoaDon_tbl_ChiTietHD", Storage="_tbl_HoaDon", ThisKey="MaHD", OtherKey="MaHoaDon", IsForeignKey=true)]
		public tbl_HoaDon tbl_HoaDon
		{
			get
			{
				return this._tbl_HoaDon.Entity;
			}
			set
			{
				tbl_HoaDon previousValue = this._tbl_HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._tbl_HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_HoaDon.Entity = null;
						previousValue.tbl_ChiTietHDs.Remove(this);
					}
					this._tbl_HoaDon.Entity = value;
					if ((value != null))
					{
						value.tbl_ChiTietHDs.Add(this);
						this._MaHD = value.MaHoaDon;
					}
					else
					{
						this._MaHD = default(int);
					}
					this.SendPropertyChanged("tbl_HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_SanPham_tbl_ChiTietHD", Storage="_tbl_SanPham", ThisKey="MaSP", OtherKey="MaSanPham", IsForeignKey=true)]
		public tbl_SanPham tbl_SanPham
		{
			get
			{
				return this._tbl_SanPham.Entity;
			}
			set
			{
				tbl_SanPham previousValue = this._tbl_SanPham.Entity;
				if (((previousValue != value) 
							|| (this._tbl_SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_SanPham.Entity = null;
						previousValue.tbl_ChiTietHDs.Remove(this);
					}
					this._tbl_SanPham.Entity = value;
					if ((value != null))
					{
						value.tbl_ChiTietHDs.Add(this);
						this._MaSP = value.MaSanPham;
					}
					else
					{
						this._MaSP = default(string);
					}
					this.SendPropertyChanged("tbl_SanPham");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_HoaDon")]
	public partial class tbl_HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHoaDon;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private System.Nullable<int> _MaKH;
		
		private EntitySet<tbl_ChiTietHD> _tbl_ChiTietHDs;
		
		private EntityRef<tbl_KhachHang> _tbl_KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(int value);
    partial void OnMaHoaDonChanged();
    partial void OnNgayTaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTaoChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public tbl_HoaDon()
		{
			this._tbl_ChiTietHDs = new EntitySet<tbl_ChiTietHD>(new Action<tbl_ChiTietHD>(this.attach_tbl_ChiTietHDs), new Action<tbl_ChiTietHD>(this.detach_tbl_ChiTietHDs));
			this._tbl_KhachHang = default(EntityRef<tbl_KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._tbl_KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_HoaDon_tbl_ChiTietHD", Storage="_tbl_ChiTietHDs", ThisKey="MaHoaDon", OtherKey="MaHD")]
		public EntitySet<tbl_ChiTietHD> tbl_ChiTietHDs
		{
			get
			{
				return this._tbl_ChiTietHDs;
			}
			set
			{
				this._tbl_ChiTietHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_KhachHang_tbl_HoaDon", Storage="_tbl_KhachHang", ThisKey="MaKH", OtherKey="MaKhachHang", IsForeignKey=true)]
		public tbl_KhachHang tbl_KhachHang
		{
			get
			{
				return this._tbl_KhachHang.Entity;
			}
			set
			{
				tbl_KhachHang previousValue = this._tbl_KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._tbl_KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_KhachHang.Entity = null;
						previousValue.tbl_HoaDons.Remove(this);
					}
					this._tbl_KhachHang.Entity = value;
					if ((value != null))
					{
						value.tbl_HoaDons.Add(this);
						this._MaKH = value.MaKhachHang;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_KhachHang");
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
		
		private void attach_tbl_ChiTietHDs(tbl_ChiTietHD entity)
		{
			this.SendPropertyChanging();
			entity.tbl_HoaDon = this;
		}
		
		private void detach_tbl_ChiTietHDs(tbl_ChiTietHD entity)
		{
			this.SendPropertyChanging();
			entity.tbl_HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_KhachHang")]
	public partial class tbl_KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhachHang;
		
		private string _TenKhachHang;
		
		private string _SoDienThoai;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _MatKhau;
		
		private EntitySet<tbl_HoaDon> _tbl_HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(int value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public tbl_KhachHang()
		{
			this._tbl_HoaDons = new EntitySet<tbl_HoaDon>(new Action<tbl_HoaDon>(this.attach_tbl_HoaDons), new Action<tbl_HoaDon>(this.detach_tbl_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(MAX)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(15)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(3)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(10)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_KhachHang_tbl_HoaDon", Storage="_tbl_HoaDons", ThisKey="MaKhachHang", OtherKey="MaKH")]
		public EntitySet<tbl_HoaDon> tbl_HoaDons
		{
			get
			{
				return this._tbl_HoaDons;
			}
			set
			{
				this._tbl_HoaDons.Assign(value);
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
		
		private void attach_tbl_HoaDons(tbl_HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tbl_KhachHang = this;
		}
		
		private void detach_tbl_HoaDons(tbl_HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tbl_KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Loai")]
	public partial class tbl_Loai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private string _Nhom;
		
		private EntitySet<tbl_SanPham> _tbl_SanPhams;
		
		private EntityRef<tbl_Nhom> _tbl_Nhom;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    partial void OnNhomChanging(string value);
    partial void OnNhomChanged();
    #endregion
		
		public tbl_Loai()
		{
			this._tbl_SanPhams = new EntitySet<tbl_SanPham>(new Action<tbl_SanPham>(this.attach_tbl_SanPhams), new Action<tbl_SanPham>(this.detach_tbl_SanPhams));
			this._tbl_Nhom = default(EntityRef<tbl_Nhom>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(MAX)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nhom", DbType="NVarChar(50)")]
		public string Nhom
		{
			get
			{
				return this._Nhom;
			}
			set
			{
				if ((this._Nhom != value))
				{
					if (this._tbl_Nhom.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNhomChanging(value);
					this.SendPropertyChanging();
					this._Nhom = value;
					this.SendPropertyChanged("Nhom");
					this.OnNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Loai_tbl_SanPham", Storage="_tbl_SanPhams", ThisKey="MaLoai", OtherKey="MaL")]
		public EntitySet<tbl_SanPham> tbl_SanPhams
		{
			get
			{
				return this._tbl_SanPhams;
			}
			set
			{
				this._tbl_SanPhams.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Nhom_tbl_Loai", Storage="_tbl_Nhom", ThisKey="Nhom", OtherKey="MaNhom", IsForeignKey=true)]
		public tbl_Nhom tbl_Nhom
		{
			get
			{
				return this._tbl_Nhom.Entity;
			}
			set
			{
				tbl_Nhom previousValue = this._tbl_Nhom.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Nhom.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Nhom.Entity = null;
						previousValue.tbl_Loais.Remove(this);
					}
					this._tbl_Nhom.Entity = value;
					if ((value != null))
					{
						value.tbl_Loais.Add(this);
						this._Nhom = value.MaNhom;
					}
					else
					{
						this._Nhom = default(string);
					}
					this.SendPropertyChanged("tbl_Nhom");
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
		
		private void attach_tbl_SanPhams(tbl_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Loai = this;
		}
		
		private void detach_tbl_SanPhams(tbl_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Loai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_NhaSanXuat")]
	public partial class tbl_NhaSanXuat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNSX;
		
		private string _TenNSX;
		
		private EntitySet<tbl_SanPham> _tbl_SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNSXChanging(int value);
    partial void OnMaNSXChanged();
    partial void OnTenNSXChanging(string value);
    partial void OnTenNSXChanged();
    #endregion
		
		public tbl_NhaSanXuat()
		{
			this._tbl_SanPhams = new EntitySet<tbl_SanPham>(new Action<tbl_SanPham>(this.attach_tbl_SanPhams), new Action<tbl_SanPham>(this.detach_tbl_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSX", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNSX
		{
			get
			{
				return this._MaNSX;
			}
			set
			{
				if ((this._MaNSX != value))
				{
					this.OnMaNSXChanging(value);
					this.SendPropertyChanging();
					this._MaNSX = value;
					this.SendPropertyChanged("MaNSX");
					this.OnMaNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNSX", DbType="NVarChar(100)")]
		public string TenNSX
		{
			get
			{
				return this._TenNSX;
			}
			set
			{
				if ((this._TenNSX != value))
				{
					this.OnTenNSXChanging(value);
					this.SendPropertyChanging();
					this._TenNSX = value;
					this.SendPropertyChanged("TenNSX");
					this.OnTenNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_NhaSanXuat_tbl_SanPham", Storage="_tbl_SanPhams", ThisKey="MaNSX", OtherKey="MaSX")]
		public EntitySet<tbl_SanPham> tbl_SanPhams
		{
			get
			{
				return this._tbl_SanPhams;
			}
			set
			{
				this._tbl_SanPhams.Assign(value);
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
		
		private void attach_tbl_SanPhams(tbl_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tbl_NhaSanXuat = this;
		}
		
		private void detach_tbl_SanPhams(tbl_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tbl_NhaSanXuat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Nhom")]
	public partial class tbl_Nhom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhom;
		
		private string _TenNhom;
		
		private EntitySet<tbl_Loai> _tbl_Loais;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhomChanging(string value);
    partial void OnMaNhomChanged();
    partial void OnTenNhomChanging(string value);
    partial void OnTenNhomChanged();
    #endregion
		
		public tbl_Nhom()
		{
			this._tbl_Loais = new EntitySet<tbl_Loai>(new Action<tbl_Loai>(this.attach_tbl_Loais), new Action<tbl_Loai>(this.detach_tbl_Loais));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhom", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhom
		{
			get
			{
				return this._MaNhom;
			}
			set
			{
				if ((this._MaNhom != value))
				{
					this.OnMaNhomChanging(value);
					this.SendPropertyChanging();
					this._MaNhom = value;
					this.SendPropertyChanged("MaNhom");
					this.OnMaNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhom", DbType="NVarChar(100)")]
		public string TenNhom
		{
			get
			{
				return this._TenNhom;
			}
			set
			{
				if ((this._TenNhom != value))
				{
					this.OnTenNhomChanging(value);
					this.SendPropertyChanging();
					this._TenNhom = value;
					this.SendPropertyChanged("TenNhom");
					this.OnTenNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Nhom_tbl_Loai", Storage="_tbl_Loais", ThisKey="MaNhom", OtherKey="Nhom")]
		public EntitySet<tbl_Loai> tbl_Loais
		{
			get
			{
				return this._tbl_Loais;
			}
			set
			{
				this._tbl_Loais.Assign(value);
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
		
		private void attach_tbl_Loais(tbl_Loai entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Nhom = this;
		}
		
		private void detach_tbl_Loais(tbl_Loai entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Nhom = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_SanPham")]
	public partial class tbl_SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSanPham;
		
		private string _TenSP;
		
		private string _MaL;
		
		private System.Nullable<int> _MaSX;
		
		private System.Nullable<double> _Gia;
		
		private string _GhiChu;
		
		private string _Hinh;
		
		private string _MauSac;
		
		private string _MoTa;
		
		private EntitySet<tbl_ChiTietHD> _tbl_ChiTietHDs;
		
		private EntityRef<tbl_Loai> _tbl_Loai;
		
		private EntityRef<tbl_NhaSanXuat> _tbl_NhaSanXuat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(string value);
    partial void OnMaSanPhamChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnMaLChanging(string value);
    partial void OnMaLChanged();
    partial void OnMaSXChanging(System.Nullable<int> value);
    partial void OnMaSXChanged();
    partial void OnGiaChanging(System.Nullable<double> value);
    partial void OnGiaChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnMauSacChanging(string value);
    partial void OnMauSacChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public tbl_SanPham()
		{
			this._tbl_ChiTietHDs = new EntitySet<tbl_ChiTietHD>(new Action<tbl_ChiTietHD>(this.attach_tbl_ChiTietHDs), new Action<tbl_ChiTietHD>(this.detach_tbl_ChiTietHDs));
			this._tbl_Loai = default(EntityRef<tbl_Loai>);
			this._tbl_NhaSanXuat = default(EntityRef<tbl_NhaSanXuat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(MAX)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaL", DbType="NVarChar(50)")]
		public string MaL
		{
			get
			{
				return this._MaL;
			}
			set
			{
				if ((this._MaL != value))
				{
					if (this._tbl_Loai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLChanging(value);
					this.SendPropertyChanging();
					this._MaL = value;
					this.SendPropertyChanged("MaL");
					this.OnMaLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSX", DbType="Int")]
		public System.Nullable<int> MaSX
		{
			get
			{
				return this._MaSX;
			}
			set
			{
				if ((this._MaSX != value))
				{
					if (this._tbl_NhaSanXuat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSXChanging(value);
					this.SendPropertyChanging();
					this._MaSX = value;
					this.SendPropertyChanged("MaSX");
					this.OnMaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Float")]
		public System.Nullable<double> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(MAX)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="NVarChar(MAX)")]
		public string Hinh
		{
			get
			{
				return this._Hinh;
			}
			set
			{
				if ((this._Hinh != value))
				{
					this.OnHinhChanging(value);
					this.SendPropertyChanging();
					this._Hinh = value;
					this.SendPropertyChanged("Hinh");
					this.OnHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MauSac", DbType="NChar(10)")]
		public string MauSac
		{
			get
			{
				return this._MauSac;
			}
			set
			{
				if ((this._MauSac != value))
				{
					this.OnMauSacChanging(value);
					this.SendPropertyChanging();
					this._MauSac = value;
					this.SendPropertyChanged("MauSac");
					this.OnMauSacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_SanPham_tbl_ChiTietHD", Storage="_tbl_ChiTietHDs", ThisKey="MaSanPham", OtherKey="MaSP")]
		public EntitySet<tbl_ChiTietHD> tbl_ChiTietHDs
		{
			get
			{
				return this._tbl_ChiTietHDs;
			}
			set
			{
				this._tbl_ChiTietHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Loai_tbl_SanPham", Storage="_tbl_Loai", ThisKey="MaL", OtherKey="MaLoai", IsForeignKey=true)]
		public tbl_Loai tbl_Loai
		{
			get
			{
				return this._tbl_Loai.Entity;
			}
			set
			{
				tbl_Loai previousValue = this._tbl_Loai.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Loai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Loai.Entity = null;
						previousValue.tbl_SanPhams.Remove(this);
					}
					this._tbl_Loai.Entity = value;
					if ((value != null))
					{
						value.tbl_SanPhams.Add(this);
						this._MaL = value.MaLoai;
					}
					else
					{
						this._MaL = default(string);
					}
					this.SendPropertyChanged("tbl_Loai");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_NhaSanXuat_tbl_SanPham", Storage="_tbl_NhaSanXuat", ThisKey="MaSX", OtherKey="MaNSX", IsForeignKey=true)]
		public tbl_NhaSanXuat tbl_NhaSanXuat
		{
			get
			{
				return this._tbl_NhaSanXuat.Entity;
			}
			set
			{
				tbl_NhaSanXuat previousValue = this._tbl_NhaSanXuat.Entity;
				if (((previousValue != value) 
							|| (this._tbl_NhaSanXuat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_NhaSanXuat.Entity = null;
						previousValue.tbl_SanPhams.Remove(this);
					}
					this._tbl_NhaSanXuat.Entity = value;
					if ((value != null))
					{
						value.tbl_SanPhams.Add(this);
						this._MaSX = value.MaNSX;
					}
					else
					{
						this._MaSX = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_NhaSanXuat");
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
		
		private void attach_tbl_ChiTietHDs(tbl_ChiTietHD entity)
		{
			this.SendPropertyChanging();
			entity.tbl_SanPham = this;
		}
		
		private void detach_tbl_ChiTietHDs(tbl_ChiTietHD entity)
		{
			this.SendPropertyChanging();
			entity.tbl_SanPham = null;
		}
	}
}
#pragma warning restore 1591
