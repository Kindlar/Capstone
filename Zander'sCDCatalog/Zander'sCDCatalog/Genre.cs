//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zander_sCDCatalog
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre
    {
        public Genre()
        {
            this.Songs = new HashSet<Song>();
        }
    
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    
        public virtual ICollection<Song> Songs { get; set; }
    }
}
