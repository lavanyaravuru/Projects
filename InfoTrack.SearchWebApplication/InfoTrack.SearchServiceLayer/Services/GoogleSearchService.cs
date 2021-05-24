using InfoTrack.SearchEngine;
using InfoTrack.SearchServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.SearchServiceLayer.Services
{
    /// <summary>
    /// This is the first implementation of ISearchService
    /// </summary>
    public class GoogleSearchService : ISearchService
    {
        private readonly GoogleSearchEngine searchEngine;
        public GoogleSearchService()
        {
            searchEngine = new GoogleSearchEngine();
        }
        public int DoSearch(string searchString, int searchLimit)
        {
            return searchEngine.PerformSearchAndGetSearchCount(searchString, searchLimit);
        }  
    }
}
