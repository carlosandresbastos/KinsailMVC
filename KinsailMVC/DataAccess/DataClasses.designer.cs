﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinsailMVC.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Kinsail_Sean")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLocation(Location instance);
    partial void UpdateLocation(Location instance);
    partial void DeleteLocation(Location instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Kinsail_SeanConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Location> Locations
		{
			get
			{
				return this.GetTable<Location>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Locations")]
	public partial class Location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _LocationID;
		
		private string _LocationName;
		
		private string _StreetAddress;
		
		private string _StreetAddress2;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private string _Country;
		
		private string _Directions;
		
		private string _Parking;
		
		private bool _Active;
		
		private double _Latitude;
		
		private double _Longitude;
		
		private System.Nullable<long> _Audit_ContactID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocationIDChanging(long value);
    partial void OnLocationIDChanged();
    partial void OnLocationNameChanging(string value);
    partial void OnLocationNameChanged();
    partial void OnStreetAddressChanging(string value);
    partial void OnStreetAddressChanged();
    partial void OnStreetAddress2Changing(string value);
    partial void OnStreetAddress2Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnDirectionsChanging(string value);
    partial void OnDirectionsChanged();
    partial void OnParkingChanging(string value);
    partial void OnParkingChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    partial void OnLatitudeChanging(double value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(double value);
    partial void OnLongitudeChanged();
    partial void OnAudit_ContactIDChanging(System.Nullable<long> value);
    partial void OnAudit_ContactIDChanged();
    #endregion
		
		public Location()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					this.OnLocationIDChanging(value);
					this.SendPropertyChanging();
					this._LocationID = value;
					this.SendPropertyChanged("LocationID");
					this.OnLocationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string LocationName
		{
			get
			{
				return this._LocationName;
			}
			set
			{
				if ((this._LocationName != value))
				{
					this.OnLocationNameChanging(value);
					this.SendPropertyChanging();
					this._LocationName = value;
					this.SendPropertyChanged("LocationName");
					this.OnLocationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress", DbType="NVarChar(250)")]
		public string StreetAddress
		{
			get
			{
				return this._StreetAddress;
			}
			set
			{
				if ((this._StreetAddress != value))
				{
					this.OnStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._StreetAddress = value;
					this.SendPropertyChanged("StreetAddress");
					this.OnStreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress2", DbType="NVarChar(250)")]
		public string StreetAddress2
		{
			get
			{
				return this._StreetAddress2;
			}
			set
			{
				if ((this._StreetAddress2 != value))
				{
					this.OnStreetAddress2Changing(value);
					this.SendPropertyChanging();
					this._StreetAddress2 = value;
					this.SendPropertyChanged("StreetAddress2");
					this.OnStreetAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(20)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(20)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Directions", DbType="NVarChar(MAX)")]
		public string Directions
		{
			get
			{
				return this._Directions;
			}
			set
			{
				if ((this._Directions != value))
				{
					this.OnDirectionsChanging(value);
					this.SendPropertyChanging();
					this._Directions = value;
					this.SendPropertyChanged("Directions");
					this.OnDirectionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parking", DbType="NVarChar(MAX)")]
		public string Parking
		{
			get
			{
				return this._Parking;
			}
			set
			{
				if ((this._Parking != value))
				{
					this.OnParkingChanging(value);
					this.SendPropertyChanging();
					this._Parking = value;
					this.SendPropertyChanged("Parking");
					this.OnParkingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float NOT NULL")]
		public double Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float NOT NULL")]
		public double Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Audit_ContactID", DbType="BigInt")]
		public System.Nullable<long> Audit_ContactID
		{
			get
			{
				return this._Audit_ContactID;
			}
			set
			{
				if ((this._Audit_ContactID != value))
				{
					this.OnAudit_ContactIDChanging(value);
					this.SendPropertyChanging();
					this._Audit_ContactID = value;
					this.SendPropertyChanged("Audit_ContactID");
					this.OnAudit_ContactIDChanged();
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
}
#pragma warning restore 1591
