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
    
    public partial class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }
    
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public int AlbumYear { get; set; }
        public int AlbumRating { get; set; }
        public int ArtistId { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
