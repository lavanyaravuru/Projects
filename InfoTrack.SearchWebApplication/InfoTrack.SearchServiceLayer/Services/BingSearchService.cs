using InfoTrack.SearchEngine;
using InfoTrack.SearchServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.SearchServiceLayer.Services
{
    /// <summary>
    /// This is the second implementation of ISearchService
    /// </summary>
    public class BingSearchService : ISearchService
    {
        private readonly BingSearchEngine searchEngine;
        public BingSearchService()
        {
            searchEngine = new BingSearchEngine();
        }
        public int DoSearch(string searchString, int searchLimit)
        {
            return searchEngine.PerformSearchAndGetSearchCount(searchString, searchLimit);
        }
    }
}
