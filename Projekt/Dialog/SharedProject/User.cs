//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharedProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Unit = new HashSet<Unit>();
        }
    
        public short IDUser { get; set; }
        public Nullable<short> IDGame { get; set; }
        public string Login { get; set; }
        public string Hash { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual ICollection<Unit> Unit { get; set; }
    }
}
