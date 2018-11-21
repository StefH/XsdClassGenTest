﻿//-----------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------------------------------


namespace MySpecialDomainNamespace {
    
    
    /// <summary>
    ///   Automatically generated XML type mapping for PurchaseOrder.
    /// </summary>
    /// <remarks>
    ///   This is an automaticaly generated type, please do not edit it.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/PurchaseOrderSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/PurchaseOrderSchema.xsd", IsNullable=true)]
    public partial class PurchaseOrder {
        
        private USAddress[] shipToField;
        
        private USAddress billToField;
        
        private System.DateTime orderDateField;
        
        private bool orderDateFieldSpecified;
        
        /// <summary>
        ///   Gets or sets ShipTo.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ShipTo")]
        public USAddress[] ShipTo {
            get {
                return this.shipToField;
            }
            set {
                this.shipToField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets BillTo.
        /// </summary>
        public USAddress BillTo {
            get {
                return this.billToField;
            }
            set {
                this.billToField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets OrderDate.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime OrderDate {
            get {
                return this.orderDateField;
            }
            set {
                this.orderDateField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets OrderDateSpecified.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderDateSpecified {
            get {
                return this.orderDateFieldSpecified;
            }
            set {
                this.orderDateFieldSpecified = value;
            }
        }
    }
    
    /// <summary>
    ///   Automatically generated XML type mapping for USAddress.
    /// </summary>
    /// <remarks>
    ///   This is an automaticaly generated type, please do not edit it.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/PurchaseOrderSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/PurchaseOrderSchema.xsd", IsNullable=true)]
    public partial class USAddress {
        
        private string nameField;
        
        private string streetField;
        
        private string cityField;
        
        private string stateField;
        
        private int zipField;
        
        private System.Nullable<int> zip2Field;
        
        private string countryField;
        
        /// <summary>
        ///   Initializes a new USAddress.
        /// </summary>
        public USAddress() {
            this.countryField = "US";
        }
        
        /// <summary>
        ///   Gets or sets name.
        /// </summary>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets street.
        /// </summary>
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets city.
        /// </summary>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets state.
        /// </summary>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets zip.
        /// </summary>
        public int zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets zip2.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> zip2 {
            get {
                return this.zip2Field;
            }
            set {
                this.zip2Field = value;
            }
        }
        
        /// <summary>
        ///   Gets or sets country.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }
}