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
    
    public partial class Board
    {
        public Board()
        {
            this.Field = new HashSet<Field>();
        }
    
        public short IDBoard { get; set; }
        public Nullable<short> IDGame { get; set; }
    
        public virtual ICollection<Field> Field { get; set; }
        public virtual Game Game { get; set; }
    }
}
