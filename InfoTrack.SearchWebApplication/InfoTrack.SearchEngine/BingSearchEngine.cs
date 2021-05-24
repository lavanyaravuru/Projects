using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.SearchEngine
{
    /// <summary>
    /// This is the actual bing search engine, 
    /// which has  all the logic to extact search results and findout the total count of info track link appears in top results
    /// </summary>
    public class BingSearchEngine
    {
        public int PerformSearchAndGetSearchCount(string searchString, int searchLimit)
        {
            var searchedLinks = new[]
            {
                "https://infotrack-tests.infotrack.com.au/Bing/Page01.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page02.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page03.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page04.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page05.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page06.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page07.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page08.htm",
                "https://infotrack-tests.infotrack.com.au/Bing/Page09.htm"
            };
            return searchedLinks.Length;
        }
    }
}
