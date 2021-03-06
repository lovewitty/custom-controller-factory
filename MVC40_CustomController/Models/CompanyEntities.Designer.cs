﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MVC40_CustomController.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CompanyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CompanyEntities object using the connection string found in the 'CompanyEntities' section of the application configuration file.
        /// </summary>
        public CompanyEntities() : base("name=CompanyEntities", "CompanyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyEntities object.
        /// </summary>
        public CompanyEntities(string connectionString) : base(connectionString, "CompanyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyEntities object.
        /// </summary>
        public CompanyEntities(EntityConnection connection) : base(connection, "CompanyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LoggerInformation> LoggerInformations
        {
            get
            {
                if ((_LoggerInformations == null))
                {
                    _LoggerInformations = base.CreateObjectSet<LoggerInformation>("LoggerInformations");
                }
                return _LoggerInformations;
            }
        }
        private ObjectSet<LoggerInformation> _LoggerInformations;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LoggerInformations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLoggerInformations(LoggerInformation loggerInformation)
        {
            base.AddObject("LoggerInformations", loggerInformation);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="LoggerInformation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LoggerInformation : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LoggerInformation object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="requestUrl">Initial value of the RequestUrl property.</param>
        /// <param name="browser">Initial value of the Browser property.</param>
        /// <param name="requestType">Initial value of the RequestType property.</param>
        /// <param name="userHostAddress">Initial value of the UserHostAddress property.</param>
        public static LoggerInformation CreateLoggerInformation(global::System.Int32 id, global::System.String userName, global::System.String requestUrl, global::System.String browser, global::System.String requestType, global::System.String userHostAddress)
        {
            LoggerInformation loggerInformation = new LoggerInformation();
            loggerInformation.Id = id;
            loggerInformation.UserName = userName;
            loggerInformation.RequestUrl = requestUrl;
            loggerInformation.Browser = browser;
            loggerInformation.RequestType = requestType;
            loggerInformation.UserHostAddress = userHostAddress;
            return loggerInformation;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RequestUrl
        {
            get
            {
                return _RequestUrl;
            }
            set
            {
                OnRequestUrlChanging(value);
                ReportPropertyChanging("RequestUrl");
                _RequestUrl = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RequestUrl");
                OnRequestUrlChanged();
            }
        }
        private global::System.String _RequestUrl;
        partial void OnRequestUrlChanging(global::System.String value);
        partial void OnRequestUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Browser
        {
            get
            {
                return _Browser;
            }
            set
            {
                OnBrowserChanging(value);
                ReportPropertyChanging("Browser");
                _Browser = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Browser");
                OnBrowserChanged();
            }
        }
        private global::System.String _Browser;
        partial void OnBrowserChanging(global::System.String value);
        partial void OnBrowserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RequestType
        {
            get
            {
                return _RequestType;
            }
            set
            {
                OnRequestTypeChanging(value);
                ReportPropertyChanging("RequestType");
                _RequestType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RequestType");
                OnRequestTypeChanged();
            }
        }
        private global::System.String _RequestType;
        partial void OnRequestTypeChanging(global::System.String value);
        partial void OnRequestTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserHostAddress
        {
            get
            {
                return _UserHostAddress;
            }
            set
            {
                OnUserHostAddressChanging(value);
                ReportPropertyChanging("UserHostAddress");
                _UserHostAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserHostAddress");
                OnUserHostAddressChanged();
            }
        }
        private global::System.String _UserHostAddress;
        partial void OnUserHostAddressChanging(global::System.String value);
        partial void OnUserHostAddressChanged();

        #endregion

    
    }

    #endregion

    
}
