// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;

#pragma warning disable
namespace Subsonic.Domain.API.API11
{
    [DebuggerStepThrough]
public partial class SearchResult2
{
    
        public List<Artist> Artist { get; set; }
        public List<Child> Album { get; set; }
        public List<Child> Song { get; set; }
    
    public SearchResult2()
    {
        Song = new List<Child>();
        Album = new List<Child>();
        Artist = new List<Artist>();
    }
}
}
#pragma warning restore