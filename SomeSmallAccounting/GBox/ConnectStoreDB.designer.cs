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

namespace GBox
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="For_Tests")]
	public partial class ConnectStoreDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSale(Sale instance);
    partial void UpdateSale(Sale instance);
    partial void DeleteSale(Sale instance);
    partial void InsertStore(Store instance);
    partial void UpdateStore(Store instance);
    partial void DeleteStore(Store instance);
    #endregion
		
		public ConnectStoreDBDataContext() : 
				base(global::GBox.Properties.Settings.Default.For_TestsConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectStoreDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectStoreDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectStoreDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectStoreDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sale> Sales
		{
			get
			{
				return this.GetTable<Sale>();
			}
		}
		
		public System.Data.Linq.Table<Store> Stores
		{
			get
			{
				return this.GetTable<Store>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sale")]
	public partial class Sale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ID_Product;
		
		private double _Sale_Price;
		
		private int _Sold_Qnt;
		
		private double _Price_Sum;
		
		private System.DateTime _Sale_Date;
		
		private string _Note;
		
		private EntityRef<Store> _Store;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnID_ProductChanging(int value);
    partial void OnID_ProductChanged();
    partial void OnSale_PriceChanging(double value);
    partial void OnSale_PriceChanged();
    partial void OnSold_QntChanging(int value);
    partial void OnSold_QntChanged();
    partial void OnPrice_SumChanging(double value);
    partial void OnPrice_SumChanged();
    partial void OnSale_DateChanging(System.DateTime value);
    partial void OnSale_DateChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    #endregion
		
		public Sale()
		{
			this._Store = default(EntityRef<Store>);
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
					if (this._Store.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Product", DbType="Int NOT NULL")]
		public int ID_Product
		{
			get
			{
				return this._ID_Product;
			}
			set
			{
				if ((this._ID_Product != value))
				{
					this.OnID_ProductChanging(value);
					this.SendPropertyChanging();
					this._ID_Product = value;
					this.SendPropertyChanged("ID_Product");
					this.OnID_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sale_Price", DbType="Float NOT NULL")]
		public double Sale_Price
		{
			get
			{
				return this._Sale_Price;
			}
			set
			{
				if ((this._Sale_Price != value))
				{
					this.OnSale_PriceChanging(value);
					this.SendPropertyChanging();
					this._Sale_Price = value;
					this.SendPropertyChanged("Sale_Price");
					this.OnSale_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sold_Qnt", DbType="Int NOT NULL")]
		public int Sold_Qnt
		{
			get
			{
				return this._Sold_Qnt;
			}
			set
			{
				if ((this._Sold_Qnt != value))
				{
					this.OnSold_QntChanging(value);
					this.SendPropertyChanging();
					this._Sold_Qnt = value;
					this.SendPropertyChanged("Sold_Qnt");
					this.OnSold_QntChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price_Sum", DbType="Float NOT NULL")]
		public double Price_Sum
		{
			get
			{
				return this._Price_Sum;
			}
			set
			{
				if ((this._Price_Sum != value))
				{
					this.OnPrice_SumChanging(value);
					this.SendPropertyChanging();
					this._Price_Sum = value;
					this.SendPropertyChanged("Price_Sum");
					this.OnPrice_SumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sale_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Sale_Date
		{
			get
			{
				return this._Sale_Date;
			}
			set
			{
				if ((this._Sale_Date != value))
				{
					this.OnSale_DateChanging(value);
					this.SendPropertyChanging();
					this._Sale_Date = value;
					this.SendPropertyChanged("Sale_Date");
					this.OnSale_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(MAX)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Store_Sale", Storage="_Store", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Store Store
		{
			get
			{
				return this._Store.Entity;
			}
			set
			{
				Store previousValue = this._Store.Entity;
				if (((previousValue != value) 
							|| (this._Store.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Store.Entity = null;
						previousValue.Sales.Remove(this);
					}
					this._Store.Entity = value;
					if ((value != null))
					{
						value.Sales.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Store");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Store")]
	public partial class Store : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Product;
		
		private string _Description;
		
		private System.Nullable<int> _Quantity_Start;
		
		private System.Nullable<int> _Quantity_Now;
		
		private System.Nullable<double> _Real_Price_USD;
		
		private System.Nullable<double> _Real_Price_AMD;
		
		private System.Nullable<double> _Sale_Price_AMD;
		
		private string _Note;
		
		private string _Link;
		
		private EntitySet<Sale> _Sales;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnProductChanging(string value);
    partial void OnProductChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnQuantity_StartChanging(System.Nullable<int> value);
    partial void OnQuantity_StartChanged();
    partial void OnQuantity_NowChanging(System.Nullable<int> value);
    partial void OnQuantity_NowChanged();
    partial void OnReal_Price_USDChanging(System.Nullable<double> value);
    partial void OnReal_Price_USDChanged();
    partial void OnReal_Price_AMDChanging(System.Nullable<double> value);
    partial void OnReal_Price_AMDChanged();
    partial void OnSale_Price_AMDChanging(System.Nullable<double> value);
    partial void OnSale_Price_AMDChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    #endregion
		
		public Store()
		{
			this._Sales = new EntitySet<Sale>(new Action<Sale>(this.attach_Sales), new Action<Sale>(this.detach_Sales));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Product
		{
			get
			{
				return this._Product;
			}
			set
			{
				if ((this._Product != value))
				{
					this.OnProductChanging(value);
					this.SendPropertyChanging();
					this._Product = value;
					this.SendPropertyChanged("Product");
					this.OnProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Start", DbType="Int")]
		public System.Nullable<int> Quantity_Start
		{
			get
			{
				return this._Quantity_Start;
			}
			set
			{
				if ((this._Quantity_Start != value))
				{
					this.OnQuantity_StartChanging(value);
					this.SendPropertyChanging();
					this._Quantity_Start = value;
					this.SendPropertyChanged("Quantity_Start");
					this.OnQuantity_StartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Now", DbType="Int")]
		public System.Nullable<int> Quantity_Now
		{
			get
			{
				return this._Quantity_Now;
			}
			set
			{
				if ((this._Quantity_Now != value))
				{
					this.OnQuantity_NowChanging(value);
					this.SendPropertyChanging();
					this._Quantity_Now = value;
					this.SendPropertyChanged("Quantity_Now");
					this.OnQuantity_NowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Real_Price_USD", DbType="Float")]
		public System.Nullable<double> Real_Price_USD
		{
			get
			{
				return this._Real_Price_USD;
			}
			set
			{
				if ((this._Real_Price_USD != value))
				{
					this.OnReal_Price_USDChanging(value);
					this.SendPropertyChanging();
					this._Real_Price_USD = value;
					this.SendPropertyChanged("Real_Price_USD");
					this.OnReal_Price_USDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Real_Price_AMD", DbType="Float")]
		public System.Nullable<double> Real_Price_AMD
		{
			get
			{
				return this._Real_Price_AMD;
			}
			set
			{
				if ((this._Real_Price_AMD != value))
				{
					this.OnReal_Price_AMDChanging(value);
					this.SendPropertyChanging();
					this._Real_Price_AMD = value;
					this.SendPropertyChanged("Real_Price_AMD");
					this.OnReal_Price_AMDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sale_Price_AMD", DbType="Float")]
		public System.Nullable<double> Sale_Price_AMD
		{
			get
			{
				return this._Sale_Price_AMD;
			}
			set
			{
				if ((this._Sale_Price_AMD != value))
				{
					this.OnSale_Price_AMDChanging(value);
					this.SendPropertyChanging();
					this._Sale_Price_AMD = value;
					this.SendPropertyChanged("Sale_Price_AMD");
					this.OnSale_Price_AMDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(MAX)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Store_Sale", Storage="_Sales", ThisKey="ID", OtherKey="ID")]
		public EntitySet<Sale> Sales
		{
			get
			{
				return this._Sales;
			}
			set
			{
				this._Sales.Assign(value);
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
		
		private void attach_Sales(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Store = this;
		}
		
		private void detach_Sales(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Store = null;
		}
	}
}
#pragma warning restore 1591
