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
public partial class AlbumWithSongsID3 : AlbumID3
{
    
        public List<Child> Song { get; set; }
    
    public AlbumWithSongsID3()
    {
        Song = new List<Child>();
    }
}
}
#pragma warning restore