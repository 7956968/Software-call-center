//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedFox.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class EncoderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncoderType()
        {
            this.Encoders = new HashSet<Encoder>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public ProtocolType Protocol { get; set; }
        public string ProviderJson { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encoder> Encoders { get; set; }
    }
}