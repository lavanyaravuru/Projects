using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.SearchWebApplication.Models
{
    /// <summary>
    /// This lists all types of search engines we offer
    /// This is used to delegate the user request to correct search service
    /// </summary>
    public enum SearchEngineTypeEnum
    {
        Google=1,
        Bing
    }
}
