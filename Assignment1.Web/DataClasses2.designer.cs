﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1.Web
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BusTicketing")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    partial void InsertPayment(Payment instance);
    partial void UpdatePayment(Payment instance);
    partial void DeletePayment(Payment instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
		
		public System.Data.Linq.Table<Payment> Payments
		{
			get
			{
				return this.GetTable<Payment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservation")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ReservationID;
		
		private string _ReservationDate;
		
		private string _ReservationTime;
		
		private string _ReservationFrom;
		
		private string _ReservationTo;
		
		private string _ReservationSeatNumber;
		
		private System.Nullable<int> _ReservationTotalSeat;
		
		private System.Nullable<decimal> _ReservationTotalFare;
		
		private string _ReservationBusNumber;
		
		private string _ReservationName;
		
		private string _ReservationPhoneNo;
		
		private string _ReservationIC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReservationIDChanging(string value);
    partial void OnReservationIDChanged();
    partial void OnReservationDateChanging(string value);
    partial void OnReservationDateChanged();
    partial void OnReservationTimeChanging(string value);
    partial void OnReservationTimeChanged();
    partial void OnReservationFromChanging(string value);
    partial void OnReservationFromChanged();
    partial void OnReservationToChanging(string value);
    partial void OnReservationToChanged();
    partial void OnReservationSeatNumberChanging(string value);
    partial void OnReservationSeatNumberChanged();
    partial void OnReservationTotalSeatChanging(System.Nullable<int> value);
    partial void OnReservationTotalSeatChanged();
    partial void OnReservationTotalFareChanging(System.Nullable<decimal> value);
    partial void OnReservationTotalFareChanged();
    partial void OnReservationBusNumberChanging(string value);
    partial void OnReservationBusNumberChanged();
    partial void OnReservationNameChanging(string value);
    partial void OnReservationNameChanged();
    partial void OnReservationPhoneNoChanging(string value);
    partial void OnReservationPhoneNoChanged();
    partial void OnReservationICChanging(string value);
    partial void OnReservationICChanged();
    #endregion
		
		public Reservation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ReservationID
		{
			get
			{
				return this._ReservationID;
			}
			set
			{
				if ((this._ReservationID != value))
				{
					this.OnReservationIDChanging(value);
					this.SendPropertyChanging();
					this._ReservationID = value;
					this.SendPropertyChanged("ReservationID");
					this.OnReservationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationDate", DbType="NVarChar(50)")]
		public string ReservationDate
		{
			get
			{
				return this._ReservationDate;
			}
			set
			{
				if ((this._ReservationDate != value))
				{
					this.OnReservationDateChanging(value);
					this.SendPropertyChanging();
					this._ReservationDate = value;
					this.SendPropertyChanged("ReservationDate");
					this.OnReservationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTime", DbType="NVarChar(50)")]
		public string ReservationTime
		{
			get
			{
				return this._ReservationTime;
			}
			set
			{
				if ((this._ReservationTime != value))
				{
					this.OnReservationTimeChanging(value);
					this.SendPropertyChanging();
					this._ReservationTime = value;
					this.SendPropertyChanged("ReservationTime");
					this.OnReservationTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationFrom", DbType="NVarChar(50)")]
		public string ReservationFrom
		{
			get
			{
				return this._ReservationFrom;
			}
			set
			{
				if ((this._ReservationFrom != value))
				{
					this.OnReservationFromChanging(value);
					this.SendPropertyChanging();
					this._ReservationFrom = value;
					this.SendPropertyChanged("ReservationFrom");
					this.OnReservationFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTo", DbType="NVarChar(50)")]
		public string ReservationTo
		{
			get
			{
				return this._ReservationTo;
			}
			set
			{
				if ((this._ReservationTo != value))
				{
					this.OnReservationToChanging(value);
					this.SendPropertyChanging();
					this._ReservationTo = value;
					this.SendPropertyChanged("ReservationTo");
					this.OnReservationToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationSeatNumber", DbType="NVarChar(MAX)")]
		public string ReservationSeatNumber
		{
			get
			{
				return this._ReservationSeatNumber;
			}
			set
			{
				if ((this._ReservationSeatNumber != value))
				{
					this.OnReservationSeatNumberChanging(value);
					this.SendPropertyChanging();
					this._ReservationSeatNumber = value;
					this.SendPropertyChanged("ReservationSeatNumber");
					this.OnReservationSeatNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTotalSeat", DbType="Int")]
		public System.Nullable<int> ReservationTotalSeat
		{
			get
			{
				return this._ReservationTotalSeat;
			}
			set
			{
				if ((this._ReservationTotalSeat != value))
				{
					this.OnReservationTotalSeatChanging(value);
					this.SendPropertyChanging();
					this._ReservationTotalSeat = value;
					this.SendPropertyChanged("ReservationTotalSeat");
					this.OnReservationTotalSeatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTotalFare", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ReservationTotalFare
		{
			get
			{
				return this._ReservationTotalFare;
			}
			set
			{
				if ((this._ReservationTotalFare != value))
				{
					this.OnReservationTotalFareChanging(value);
					this.SendPropertyChanging();
					this._ReservationTotalFare = value;
					this.SendPropertyChanged("ReservationTotalFare");
					this.OnReservationTotalFareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationBusNumber", DbType="NVarChar(50)")]
		public string ReservationBusNumber
		{
			get
			{
				return this._ReservationBusNumber;
			}
			set
			{
				if ((this._ReservationBusNumber != value))
				{
					this.OnReservationBusNumberChanging(value);
					this.SendPropertyChanging();
					this._ReservationBusNumber = value;
					this.SendPropertyChanged("ReservationBusNumber");
					this.OnReservationBusNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationName", DbType="NVarChar(MAX)")]
		public string ReservationName
		{
			get
			{
				return this._ReservationName;
			}
			set
			{
				if ((this._ReservationName != value))
				{
					this.OnReservationNameChanging(value);
					this.SendPropertyChanging();
					this._ReservationName = value;
					this.SendPropertyChanged("ReservationName");
					this.OnReservationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationPhoneNo", DbType="NVarChar(50)")]
		public string ReservationPhoneNo
		{
			get
			{
				return this._ReservationPhoneNo;
			}
			set
			{
				if ((this._ReservationPhoneNo != value))
				{
					this.OnReservationPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._ReservationPhoneNo = value;
					this.SendPropertyChanged("ReservationPhoneNo");
					this.OnReservationPhoneNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationIC", DbType="NVarChar(50)")]
		public string ReservationIC
		{
			get
			{
				return this._ReservationIC;
			}
			set
			{
				if ((this._ReservationIC != value))
				{
					this.OnReservationICChanging(value);
					this.SendPropertyChanging();
					this._ReservationIC = value;
					this.SendPropertyChanged("ReservationIC");
					this.OnReservationICChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payment")]
	public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ReservationID;
		
		private string _ReservationDate;
		
		private string _ReservationTime;
		
		private string _ReservationFrom;
		
		private string _ReservationTo;
		
		private string _ReservationSeatNumber;
		
		private System.Nullable<int> _ReservationTotalSeat;
		
		private System.Nullable<decimal> _ReservationTotalFare;
		
		private string _ReservationBusNumber;
		
		private string _ReservationName;
		
		private string _ReservationPhoneNo;
		
		private string _ReservationIC;
		
		private string _PaymentAmount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReservationIDChanging(string value);
    partial void OnReservationIDChanged();
    partial void OnReservationDateChanging(string value);
    partial void OnReservationDateChanged();
    partial void OnReservationTimeChanging(string value);
    partial void OnReservationTimeChanged();
    partial void OnReservationFromChanging(string value);
    partial void OnReservationFromChanged();
    partial void OnReservationToChanging(string value);
    partial void OnReservationToChanged();
    partial void OnReservationSeatNumberChanging(string value);
    partial void OnReservationSeatNumberChanged();
    partial void OnReservationTotalSeatChanging(System.Nullable<int> value);
    partial void OnReservationTotalSeatChanged();
    partial void OnReservationTotalFareChanging(System.Nullable<decimal> value);
    partial void OnReservationTotalFareChanged();
    partial void OnReservationBusNumberChanging(string value);
    partial void OnReservationBusNumberChanged();
    partial void OnReservationNameChanging(string value);
    partial void OnReservationNameChanged();
    partial void OnReservationPhoneNoChanging(string value);
    partial void OnReservationPhoneNoChanged();
    partial void OnReservationICChanging(string value);
    partial void OnReservationICChanged();
    partial void OnPaymentAmountChanging(string value);
    partial void OnPaymentAmountChanged();
    #endregion
		
		public Payment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ReservationID
		{
			get
			{
				return this._ReservationID;
			}
			set
			{
				if ((this._ReservationID != value))
				{
					this.OnReservationIDChanging(value);
					this.SendPropertyChanging();
					this._ReservationID = value;
					this.SendPropertyChanged("ReservationID");
					this.OnReservationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationDate", DbType="NVarChar(50)")]
		public string ReservationDate
		{
			get
			{
				return this._ReservationDate;
			}
			set
			{
				if ((this._ReservationDate != value))
				{
					this.OnReservationDateChanging(value);
					this.SendPropertyChanging();
					this._ReservationDate = value;
					this.SendPropertyChanged("ReservationDate");
					this.OnReservationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTime", DbType="NVarChar(50)")]
		public string ReservationTime
		{
			get
			{
				return this._ReservationTime;
			}
			set
			{
				if ((this._ReservationTime != value))
				{
					this.OnReservationTimeChanging(value);
					this.SendPropertyChanging();
					this._ReservationTime = value;
					this.SendPropertyChanged("ReservationTime");
					this.OnReservationTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationFrom", DbType="NVarChar(50)")]
		public string ReservationFrom
		{
			get
			{
				return this._ReservationFrom;
			}
			set
			{
				if ((this._ReservationFrom != value))
				{
					this.OnReservationFromChanging(value);
					this.SendPropertyChanging();
					this._ReservationFrom = value;
					this.SendPropertyChanged("ReservationFrom");
					this.OnReservationFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTo", DbType="NVarChar(50)")]
		public string ReservationTo
		{
			get
			{
				return this._ReservationTo;
			}
			set
			{
				if ((this._ReservationTo != value))
				{
					this.OnReservationToChanging(value);
					this.SendPropertyChanging();
					this._ReservationTo = value;
					this.SendPropertyChanged("ReservationTo");
					this.OnReservationToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationSeatNumber", DbType="NVarChar(MAX)")]
		public string ReservationSeatNumber
		{
			get
			{
				return this._ReservationSeatNumber;
			}
			set
			{
				if ((this._ReservationSeatNumber != value))
				{
					this.OnReservationSeatNumberChanging(value);
					this.SendPropertyChanging();
					this._ReservationSeatNumber = value;
					this.SendPropertyChanged("ReservationSeatNumber");
					this.OnReservationSeatNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTotalSeat", DbType="Int")]
		public System.Nullable<int> ReservationTotalSeat
		{
			get
			{
				return this._ReservationTotalSeat;
			}
			set
			{
				if ((this._ReservationTotalSeat != value))
				{
					this.OnReservationTotalSeatChanging(value);
					this.SendPropertyChanging();
					this._ReservationTotalSeat = value;
					this.SendPropertyChanged("ReservationTotalSeat");
					this.OnReservationTotalSeatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationTotalFare", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ReservationTotalFare
		{
			get
			{
				return this._ReservationTotalFare;
			}
			set
			{
				if ((this._ReservationTotalFare != value))
				{
					this.OnReservationTotalFareChanging(value);
					this.SendPropertyChanging();
					this._ReservationTotalFare = value;
					this.SendPropertyChanged("ReservationTotalFare");
					this.OnReservationTotalFareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationBusNumber", DbType="NVarChar(50)")]
		public string ReservationBusNumber
		{
			get
			{
				return this._ReservationBusNumber;
			}
			set
			{
				if ((this._ReservationBusNumber != value))
				{
					this.OnReservationBusNumberChanging(value);
					this.SendPropertyChanging();
					this._ReservationBusNumber = value;
					this.SendPropertyChanged("ReservationBusNumber");
					this.OnReservationBusNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationName", DbType="NVarChar(MAX)")]
		public string ReservationName
		{
			get
			{
				return this._ReservationName;
			}
			set
			{
				if ((this._ReservationName != value))
				{
					this.OnReservationNameChanging(value);
					this.SendPropertyChanging();
					this._ReservationName = value;
					this.SendPropertyChanged("ReservationName");
					this.OnReservationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationPhoneNo", DbType="NVarChar(50)")]
		public string ReservationPhoneNo
		{
			get
			{
				return this._ReservationPhoneNo;
			}
			set
			{
				if ((this._ReservationPhoneNo != value))
				{
					this.OnReservationPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._ReservationPhoneNo = value;
					this.SendPropertyChanged("ReservationPhoneNo");
					this.OnReservationPhoneNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationIC", DbType="NVarChar(50)")]
		public string ReservationIC
		{
			get
			{
				return this._ReservationIC;
			}
			set
			{
				if ((this._ReservationIC != value))
				{
					this.OnReservationICChanging(value);
					this.SendPropertyChanging();
					this._ReservationIC = value;
					this.SendPropertyChanged("ReservationIC");
					this.OnReservationICChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentAmount", DbType="NVarChar(50)")]
		public string PaymentAmount
		{
			get
			{
				return this._PaymentAmount;
			}
			set
			{
				if ((this._PaymentAmount != value))
				{
					this.OnPaymentAmountChanging(value);
					this.SendPropertyChanging();
					this._PaymentAmount = value;
					this.SendPropertyChanged("PaymentAmount");
					this.OnPaymentAmountChanged();
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
