//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VictorDBTest1.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelString { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Released { get; set; }
        public int BoardId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string SerialNumberCode { get; set; }
        public string ZigbeeModelString { get; set; }
        public int ExtensionId { get; set; }
        public string SKU { get; set; }
        public bool CurrentTest { get; set; }
        public Nullable<int> ModelEncodingNumber { get; set; }
        public string ZplFile { get; set; }
        public bool EnableReadProtectOnDevice { get; set; }
        public string BoxLabelName { get; set; }
    }
}
