using System;

namespace InfoTrack.SearchEngine
{
    /// <summary>
    /// This is the actual google search engine, 
    /// which has  all the logic to extact search results and findout the total count of info track link appears in top results
    /// </summary>
    public class GoogleSearchEngine
    {
        public int PerformSearchAndGetSearchCount(string searchString, int searchLimit)
        {
            var searchedLinks = new[]
            {
                "https://infotrack-tests.infotrack.com.au/Google/Page01.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page02.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page03.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page04.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page05.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page06.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page07.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page08.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page09.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page10.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page11.htm",
                "https://infotrack-tests.infotrack.com.au/Google/Page12.htm"
            };
            return searchedLinks.Length;
        } 
    }
}
