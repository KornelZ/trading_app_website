//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LGSA_Server.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class dic_Transaction_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dic_Transaction_status()
        {
            this.transactions = new HashSet<transactions>();
        }
    
        public int ID { get; set; }
        public string name { get; set; }
        public string offer_transaction_description { get; set; }
        public System.DateTime Update_Date { get; set; }
        public int Update_Who { get; set; }
    
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transactions> transactions { get; set; }
    }
}