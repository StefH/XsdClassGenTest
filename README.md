# XsdClassGenTest
XsdClassGen Test project
Based on https://gitlab.com/pommalabs/xsdclassgen

Modifications:
- remove generation from the serialization classes and implemented a simple generic `XmlConverter` class.


### Example

#### XSD
``` xml
<?xml version="1.0" encoding="utf-8"?>
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema"
           xmlns:tns="http://tempuri.org/PurchaseOrderSchema.xsd"
           targetNamespace="http://tempuri.org/PurchaseOrderSchema.xsd"
           elementFormDefault="qualified">
  <xsd:element name="PurchaseOrder" type="tns:PurchaseOrder"/>
  <xsd:complexType name="PurchaseOrder">
    <xsd:sequence>
      <xsd:element name="ShipTo" type="tns:USAddress" maxOccurs="2"/>
      <xsd:element name="BillTo" type="tns:USAddress"/>
    </xsd:sequence>
    <xsd:attribute name="OrderDate" type="xsd:date"/>
  </xsd:complexType>

  <xsd:element name="USAddress" type="tns:USAddress"/>
  <xsd:complexType name="USAddress">
    <xsd:sequence>
      <xsd:element name="name"   type="xsd:string"/>
      <xsd:element name="street" type="xsd:string"/>
      <xsd:element name="city"   type="xsd:string"/>
      <xsd:element name="state"  type="xsd:string"/>
      <xsd:element name="zip"    type="xsd:int"/>
      <xsd:element name="zip2"   type="xsd:int" nillable="true"/>
    </xsd:sequence>
    <xsd:attribute name="country" type="xsd:NMTOKEN" fixed="US"/>
  </xsd:complexType>
</xsd:schema>
```
#### Generated c# Code
``` c#
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

        // More ...
```

### Usage

This code:
``` c#
var p = new PurchaseOrder
{
    BillTo = new USAddress
    {
        country = "NL",
        name = "test",
        zip = 55656
    }
};

string s = XmlConverter.SerializeObject(p);
Console.WriteLine(s);
```

Generates this XML:

``` xml
<PurchaseOrder xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://tempuri.org/PurchaseOrderSchema.xsd">
  <BillTo country="NL">
    <name>test</name>
    <zip>55656</zip>
    <zip2 xsi:nil="true" />
  </BillTo>
</PurchaseOrder>
```