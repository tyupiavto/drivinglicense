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

namespace DrivingLicense.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyDbContext")]
	public partial class DrivingLicenseDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDrivingLicenseData(DrivingLicenseData instance);
    partial void UpdateDrivingLicenseData(DrivingLicenseData instance);
    partial void DeleteDrivingLicenseData(DrivingLicenseData instance);
    #endregion
		
		public DrivingLicenseDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyDbContextConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DrivingLicenseDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrivingLicenseDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrivingLicenseDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrivingLicenseDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DrivingLicenseData> DrivingLicenseDatas
		{
			get
			{
				return this.GetTable<DrivingLicenseData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DrivingLicenseData")]
	public partial class DrivingLicenseData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _AnswerOne;
		
		private string _AnswerTwo;
		
		private string _AnswerThree;
		
		private string _AnswerFour;
		
		private int _CorrectAnswer;
		
		private int _AnswersPoints;
		
		private int _ImageSize;
		
		private int _ImageNumber;
		
		private int _SteppeNumber;
		
		private string _Definition;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAnswerOneChanging(string value);
    partial void OnAnswerOneChanged();
    partial void OnAnswerTwoChanging(string value);
    partial void OnAnswerTwoChanged();
    partial void OnAnswerThreeChanging(string value);
    partial void OnAnswerThreeChanged();
    partial void OnAnswerFourChanging(string value);
    partial void OnAnswerFourChanged();
    partial void OnCorrectAnswerChanging(int value);
    partial void OnCorrectAnswerChanged();
    partial void OnAnswersPointsChanging(int value);
    partial void OnAnswersPointsChanged();
    partial void OnImageSizeChanging(int value);
    partial void OnImageSizeChanged();
    partial void OnImageNumberChanging(int value);
    partial void OnImageNumberChanged();
    partial void OnSteppeNumberChanging(int value);
    partial void OnSteppeNumberChanged();
    partial void OnDefinitionChanging(string value);
    partial void OnDefinitionChanged();
    #endregion
		
		public DrivingLicenseData()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerOne", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AnswerOne
		{
			get
			{
				return this._AnswerOne;
			}
			set
			{
				if ((this._AnswerOne != value))
				{
					this.OnAnswerOneChanging(value);
					this.SendPropertyChanging();
					this._AnswerOne = value;
					this.SendPropertyChanged("AnswerOne");
					this.OnAnswerOneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerTwo", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AnswerTwo
		{
			get
			{
				return this._AnswerTwo;
			}
			set
			{
				if ((this._AnswerTwo != value))
				{
					this.OnAnswerTwoChanging(value);
					this.SendPropertyChanging();
					this._AnswerTwo = value;
					this.SendPropertyChanged("AnswerTwo");
					this.OnAnswerTwoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerThree", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AnswerThree
		{
			get
			{
				return this._AnswerThree;
			}
			set
			{
				if ((this._AnswerThree != value))
				{
					this.OnAnswerThreeChanging(value);
					this.SendPropertyChanging();
					this._AnswerThree = value;
					this.SendPropertyChanged("AnswerThree");
					this.OnAnswerThreeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerFour", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AnswerFour
		{
			get
			{
				return this._AnswerFour;
			}
			set
			{
				if ((this._AnswerFour != value))
				{
					this.OnAnswerFourChanging(value);
					this.SendPropertyChanging();
					this._AnswerFour = value;
					this.SendPropertyChanged("AnswerFour");
					this.OnAnswerFourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorrectAnswer", DbType="Int NOT NULL")]
		public int CorrectAnswer
		{
			get
			{
				return this._CorrectAnswer;
			}
			set
			{
				if ((this._CorrectAnswer != value))
				{
					this.OnCorrectAnswerChanging(value);
					this.SendPropertyChanging();
					this._CorrectAnswer = value;
					this.SendPropertyChanged("CorrectAnswer");
					this.OnCorrectAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswersPoints", DbType="Int NOT NULL")]
		public int AnswersPoints
		{
			get
			{
				return this._AnswersPoints;
			}
			set
			{
				if ((this._AnswersPoints != value))
				{
					this.OnAnswersPointsChanging(value);
					this.SendPropertyChanging();
					this._AnswersPoints = value;
					this.SendPropertyChanged("AnswersPoints");
					this.OnAnswersPointsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageSize", DbType="Int NOT NULL")]
		public int ImageSize
		{
			get
			{
				return this._ImageSize;
			}
			set
			{
				if ((this._ImageSize != value))
				{
					this.OnImageSizeChanging(value);
					this.SendPropertyChanging();
					this._ImageSize = value;
					this.SendPropertyChanged("ImageSize");
					this.OnImageSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageNumber", DbType="Int NOT NULL")]
		public int ImageNumber
		{
			get
			{
				return this._ImageNumber;
			}
			set
			{
				if ((this._ImageNumber != value))
				{
					this.OnImageNumberChanging(value);
					this.SendPropertyChanging();
					this._ImageNumber = value;
					this.SendPropertyChanged("ImageNumber");
					this.OnImageNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SteppeNumber", DbType="Int NOT NULL")]
		public int SteppeNumber
		{
			get
			{
				return this._SteppeNumber;
			}
			set
			{
				if ((this._SteppeNumber != value))
				{
					this.OnSteppeNumberChanging(value);
					this.SendPropertyChanging();
					this._SteppeNumber = value;
					this.SendPropertyChanged("SteppeNumber");
					this.OnSteppeNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Definition", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Definition
		{
			get
			{
				return this._Definition;
			}
			set
			{
				if ((this._Definition != value))
				{
					this.OnDefinitionChanging(value);
					this.SendPropertyChanging();
					this._Definition = value;
					this.SendPropertyChanged("Definition");
					this.OnDefinitionChanged();
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
