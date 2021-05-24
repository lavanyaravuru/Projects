using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.SearchServiceLayer.Interfaces
{
    /// <summary>
    /// This is search interface 
    /// </summary>
    public interface ISearchService
    {
        int DoSearch(string searchString, int searchLimit);
    }
}
