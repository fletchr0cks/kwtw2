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

namespace kwtwsite.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db96bccf3def02407592bda59e000bc2b9")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSegment(Segment instance);
    partial void UpdateSegment(Segment instance);
    partial void DeleteSegment(Segment instance);
    partial void InsertTopWeather(TopWeather instance);
    partial void UpdateTopWeather(TopWeather instance);
    partial void DeleteTopWeather(TopWeather instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertView(View instance);
    partial void UpdateView(View instance);
    partial void DeleteView(View instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db96bccf3def02407592bda59e000bc2b9ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Segment> Segments
		{
			get
			{
				return this.GetTable<Segment>();
			}
		}
		
		public System.Data.Linq.Table<TopWeather> TopWeathers
		{
			get
			{
				return this.GetTable<TopWeather>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<View> Views
		{
			get
			{
				return this.GetTable<View>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Segments")]
	public partial class Segment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SID;
		
		private int _SegmentID;
		
		private string _BearingArray;
		
		private string _Polyline;
		
		private string _SegmentName;
		
		private string _latlng;
		
		private System.Nullable<System.DateTime> _Timestamp;
		
		private System.Nullable<int> _PrivateSeg;
		
		private string _Location;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSIDChanging(int value);
    partial void OnSIDChanged();
    partial void OnSegmentIDChanging(int value);
    partial void OnSegmentIDChanged();
    partial void OnBearingArrayChanging(string value);
    partial void OnBearingArrayChanged();
    partial void OnPolylineChanging(string value);
    partial void OnPolylineChanged();
    partial void OnSegmentNameChanging(string value);
    partial void OnSegmentNameChanged();
    partial void OnlatlngChanging(string value);
    partial void OnlatlngChanged();
    partial void OnTimestampChanging(System.Nullable<System.DateTime> value);
    partial void OnTimestampChanged();
    partial void OnPrivateSegChanging(System.Nullable<int> value);
    partial void OnPrivateSegChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
		
		public Segment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegmentID", DbType="Int NOT NULL")]
		public int SegmentID
		{
			get
			{
				return this._SegmentID;
			}
			set
			{
				if ((this._SegmentID != value))
				{
					this.OnSegmentIDChanging(value);
					this.SendPropertyChanging();
					this._SegmentID = value;
					this.SendPropertyChanged("SegmentID");
					this.OnSegmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BearingArray", DbType="VarChar(50)")]
		public string BearingArray
		{
			get
			{
				return this._BearingArray;
			}
			set
			{
				if ((this._BearingArray != value))
				{
					this.OnBearingArrayChanging(value);
					this.SendPropertyChanging();
					this._BearingArray = value;
					this.SendPropertyChanged("BearingArray");
					this.OnBearingArrayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Polyline", DbType="VarChar(MAX)")]
		public string Polyline
		{
			get
			{
				return this._Polyline;
			}
			set
			{
				if ((this._Polyline != value))
				{
					this.OnPolylineChanging(value);
					this.SendPropertyChanging();
					this._Polyline = value;
					this.SendPropertyChanged("Polyline");
					this.OnPolylineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegmentName", DbType="VarChar(MAX)")]
		public string SegmentName
		{
			get
			{
				return this._SegmentName;
			}
			set
			{
				if ((this._SegmentName != value))
				{
					this.OnSegmentNameChanging(value);
					this.SendPropertyChanging();
					this._SegmentName = value;
					this.SendPropertyChanged("SegmentName");
					this.OnSegmentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_latlng", DbType="VarChar(50)")]
		public string latlng
		{
			get
			{
				return this._latlng;
			}
			set
			{
				if ((this._latlng != value))
				{
					this.OnlatlngChanging(value);
					this.SendPropertyChanging();
					this._latlng = value;
					this.SendPropertyChanged("latlng");
					this.OnlatlngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrivateSeg", DbType="Int")]
		public System.Nullable<int> PrivateSeg
		{
			get
			{
				return this._PrivateSeg;
			}
			set
			{
				if ((this._PrivateSeg != value))
				{
					this.OnPrivateSegChanging(value);
					this.SendPropertyChanging();
					this._PrivateSeg = value;
					this.SendPropertyChanged("PrivateSeg");
					this.OnPrivateSegChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(MAX)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TopWeather")]
	public partial class TopWeather : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _SegID;
		
		private int _UserID;
		
		private int _Windspeed;
		
		private int _Stars;
		
		private System.Nullable<System.DateTime> _Timestamp;
		
		private string _latlng;
		
		private string _epoch;
		
		private string _TS_pretty;
		
		private string _SegName;
		
		private string _Polyline;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSegIDChanging(int value);
    partial void OnSegIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnWindspeedChanging(int value);
    partial void OnWindspeedChanged();
    partial void OnStarsChanging(int value);
    partial void OnStarsChanged();
    partial void OnTimestampChanging(System.Nullable<System.DateTime> value);
    partial void OnTimestampChanged();
    partial void OnlatlngChanging(string value);
    partial void OnlatlngChanged();
    partial void OnepochChanging(string value);
    partial void OnepochChanged();
    partial void OnTS_prettyChanging(string value);
    partial void OnTS_prettyChanged();
    partial void OnSegNameChanging(string value);
    partial void OnSegNameChanged();
    partial void OnPolylineChanging(string value);
    partial void OnPolylineChanged();
    #endregion
		
		public TopWeather()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegID", DbType="Int NOT NULL")]
		public int SegID
		{
			get
			{
				return this._SegID;
			}
			set
			{
				if ((this._SegID != value))
				{
					this.OnSegIDChanging(value);
					this.SendPropertyChanging();
					this._SegID = value;
					this.SendPropertyChanged("SegID");
					this.OnSegIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Windspeed", DbType="Int NOT NULL")]
		public int Windspeed
		{
			get
			{
				return this._Windspeed;
			}
			set
			{
				if ((this._Windspeed != value))
				{
					this.OnWindspeedChanging(value);
					this.SendPropertyChanging();
					this._Windspeed = value;
					this.SendPropertyChanged("Windspeed");
					this.OnWindspeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stars", DbType="Int NOT NULL")]
		public int Stars
		{
			get
			{
				return this._Stars;
			}
			set
			{
				if ((this._Stars != value))
				{
					this.OnStarsChanging(value);
					this.SendPropertyChanging();
					this._Stars = value;
					this.SendPropertyChanged("Stars");
					this.OnStarsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_latlng", DbType="VarChar(50)")]
		public string latlng
		{
			get
			{
				return this._latlng;
			}
			set
			{
				if ((this._latlng != value))
				{
					this.OnlatlngChanging(value);
					this.SendPropertyChanging();
					this._latlng = value;
					this.SendPropertyChanged("latlng");
					this.OnlatlngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_epoch", DbType="VarChar(50)")]
		public string epoch
		{
			get
			{
				return this._epoch;
			}
			set
			{
				if ((this._epoch != value))
				{
					this.OnepochChanging(value);
					this.SendPropertyChanging();
					this._epoch = value;
					this.SendPropertyChanged("epoch");
					this.OnepochChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TS_pretty", DbType="VarChar(MAX)")]
		public string TS_pretty
		{
			get
			{
				return this._TS_pretty;
			}
			set
			{
				if ((this._TS_pretty != value))
				{
					this.OnTS_prettyChanging(value);
					this.SendPropertyChanging();
					this._TS_pretty = value;
					this.SendPropertyChanged("TS_pretty");
					this.OnTS_prettyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegName", DbType="VarChar(MAX)")]
		public string SegName
		{
			get
			{
				return this._SegName;
			}
			set
			{
				if ((this._SegName != value))
				{
					this.OnSegNameChanging(value);
					this.SendPropertyChanging();
					this._SegName = value;
					this.SendPropertyChanged("SegName");
					this.OnSegNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Polyline", DbType="VarChar(MAX)")]
		public string Polyline
		{
			get
			{
				return this._Polyline;
			}
			set
			{
				if ((this._Polyline != value))
				{
					this.OnPolylineChanging(value);
					this.SendPropertyChanging();
					this._Polyline = value;
					this.SendPropertyChanged("Polyline");
					this.OnPolylineChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _StravaID;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _City;
		
		private string _Country;
		
		private System.Nullable<decimal> _Lat;
		
		private System.Nullable<decimal> _Long;
		
		private System.Nullable<int> _Credits;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<int> _CreditsWait;
		
		private System.Nullable<int> _Activities;
		
		private System.Nullable<int> _Segments;
		
		private string _latlng;
		
		private string _logdata;
		
		private System.Nullable<System.DateTime> _FirstLogin;
		
		private string _LastRefresh;
		
		private string _PaymentID;
		
		private System.Nullable<System.DateTime> _PaymentDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStravaIDChanging(int value);
    partial void OnStravaIDChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnLatChanging(System.Nullable<decimal> value);
    partial void OnLatChanged();
    partial void OnLongChanging(System.Nullable<decimal> value);
    partial void OnLongChanged();
    partial void OnCreditsChanging(System.Nullable<int> value);
    partial void OnCreditsChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnCreditsWaitChanging(System.Nullable<int> value);
    partial void OnCreditsWaitChanged();
    partial void OnActivitiesChanging(System.Nullable<int> value);
    partial void OnActivitiesChanged();
    partial void OnSegmentsChanging(System.Nullable<int> value);
    partial void OnSegmentsChanged();
    partial void OnlatlngChanging(string value);
    partial void OnlatlngChanged();
    partial void OnlogdataChanging(string value);
    partial void OnlogdataChanged();
    partial void OnFirstLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnFirstLoginChanged();
    partial void OnLastRefreshChanging(string value);
    partial void OnLastRefreshChanged();
    partial void OnPaymentIDChanging(string value);
    partial void OnPaymentIDChanged();
    partial void OnPaymentDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPaymentDateChanged();
    #endregion
		
		public User()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StravaID", DbType="Int NOT NULL")]
		public int StravaID
		{
			get
			{
				return this._StravaID;
			}
			set
			{
				if ((this._StravaID != value))
				{
					this.OnStravaIDChanging(value);
					this.SendPropertyChanging();
					this._StravaID = value;
					this.SendPropertyChanged("StravaID");
					this.OnStravaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="VarChar(MAX)")]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="VarChar(MAX)")]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this.OnLatChanging(value);
					this.SendPropertyChanging();
					this._Lat = value;
					this.SendPropertyChanged("Lat");
					this.OnLatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this.OnLongChanging(value);
					this.SendPropertyChanging();
					this._Long = value;
					this.SendPropertyChanged("Long");
					this.OnLongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credits", DbType="Int")]
		public System.Nullable<int> Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreditsWait", DbType="Int")]
		public System.Nullable<int> CreditsWait
		{
			get
			{
				return this._CreditsWait;
			}
			set
			{
				if ((this._CreditsWait != value))
				{
					this.OnCreditsWaitChanging(value);
					this.SendPropertyChanging();
					this._CreditsWait = value;
					this.SendPropertyChanged("CreditsWait");
					this.OnCreditsWaitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activities", DbType="Int")]
		public System.Nullable<int> Activities
		{
			get
			{
				return this._Activities;
			}
			set
			{
				if ((this._Activities != value))
				{
					this.OnActivitiesChanging(value);
					this.SendPropertyChanging();
					this._Activities = value;
					this.SendPropertyChanged("Activities");
					this.OnActivitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Segments", DbType="Int")]
		public System.Nullable<int> Segments
		{
			get
			{
				return this._Segments;
			}
			set
			{
				if ((this._Segments != value))
				{
					this.OnSegmentsChanging(value);
					this.SendPropertyChanging();
					this._Segments = value;
					this.SendPropertyChanged("Segments");
					this.OnSegmentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_latlng", DbType="VarChar(50)")]
		public string latlng
		{
			get
			{
				return this._latlng;
			}
			set
			{
				if ((this._latlng != value))
				{
					this.OnlatlngChanging(value);
					this.SendPropertyChanging();
					this._latlng = value;
					this.SendPropertyChanged("latlng");
					this.OnlatlngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logdata", DbType="VarChar(MAX)")]
		public string logdata
		{
			get
			{
				return this._logdata;
			}
			set
			{
				if ((this._logdata != value))
				{
					this.OnlogdataChanging(value);
					this.SendPropertyChanging();
					this._logdata = value;
					this.SendPropertyChanged("logdata");
					this.OnlogdataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstLogin", DbType="Date")]
		public System.Nullable<System.DateTime> FirstLogin
		{
			get
			{
				return this._FirstLogin;
			}
			set
			{
				if ((this._FirstLogin != value))
				{
					this.OnFirstLoginChanging(value);
					this.SendPropertyChanging();
					this._FirstLogin = value;
					this.SendPropertyChanged("FirstLogin");
					this.OnFirstLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastRefresh", DbType="NChar(10)")]
		public string LastRefresh
		{
			get
			{
				return this._LastRefresh;
			}
			set
			{
				if ((this._LastRefresh != value))
				{
					this.OnLastRefreshChanging(value);
					this.SendPropertyChanging();
					this._LastRefresh = value;
					this.SendPropertyChanged("LastRefresh");
					this.OnLastRefreshChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentID", DbType="VarChar(MAX)")]
		public string PaymentID
		{
			get
			{
				return this._PaymentID;
			}
			set
			{
				if ((this._PaymentID != value))
				{
					this.OnPaymentIDChanging(value);
					this.SendPropertyChanging();
					this._PaymentID = value;
					this.SendPropertyChanged("PaymentID");
					this.OnPaymentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentDate", DbType="Date")]
		public System.Nullable<System.DateTime> PaymentDate
		{
			get
			{
				return this._PaymentDate;
			}
			set
			{
				if ((this._PaymentDate != value))
				{
					this.OnPaymentDateChanging(value);
					this.SendPropertyChanging();
					this._PaymentDate = value;
					this.SendPropertyChanged("PaymentDate");
					this.OnPaymentDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Views")]
	public partial class View : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VID;
		
		private System.Nullable<int> _SegID;
		
		private System.Nullable<int> _Timestamp;
		
		private System.Nullable<int> _UserID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVIDChanging(int value);
    partial void OnVIDChanged();
    partial void OnSegIDChanging(System.Nullable<int> value);
    partial void OnSegIDChanged();
    partial void OnTimestampChanging(System.Nullable<int> value);
    partial void OnTimestampChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public View()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VID
		{
			get
			{
				return this._VID;
			}
			set
			{
				if ((this._VID != value))
				{
					this.OnVIDChanging(value);
					this.SendPropertyChanging();
					this._VID = value;
					this.SendPropertyChanged("VID");
					this.OnVIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegID", DbType="Int")]
		public System.Nullable<int> SegID
		{
			get
			{
				return this._SegID;
			}
			set
			{
				if ((this._SegID != value))
				{
					this.OnSegIDChanging(value);
					this.SendPropertyChanging();
					this._SegID = value;
					this.SendPropertyChanged("SegID");
					this.OnSegIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="Int")]
		public System.Nullable<int> Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
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
