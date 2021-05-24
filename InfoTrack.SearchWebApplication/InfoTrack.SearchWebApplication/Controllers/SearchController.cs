using InfoTrack.SearchServiceLayer.Interfaces;
using InfoTrack.SearchWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace InfoTrack.SearchWebApplication.Controllers
{
    public class SearchController : Controller
    {
        private IConfiguration _configuration;
        private Func<SearchEngineTypeEnum, ISearchService> _searchServiceDelegate;

        public SearchController(Func<SearchEngineTypeEnum, ISearchService> searchServiceDelegate, IConfiguration configuration)
        {
            _searchServiceDelegate = searchServiceDelegate;
            _configuration = configuration;
        }
       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(SearchModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // get the search limit from configuration (appsettings.json)
                    var searchLimit = _configuration.GetValue<int>("SearchLimit");

                    // get the correct service implementation based on the search engine type selected using the service delegate
                    var searchService = _searchServiceDelegate(model.SearchEngineType);

                    // call search service method and get the search result 
                    var totalSearchResultCount = searchService.DoSearch(model.SearchString, searchLimit);
                    return new JsonResult(new
                    {
                        success = true,
                        resultCount = totalSearchResultCount
                    });

                }
                else
                {
                    return new JsonResult(new
                    {
                        success = false,
                        errorMessage = "An error occurred while performing search, please enter all the fields and try again"
                    });
                }
            }
            catch(Exception ex)
            {
                return new JsonResult(new
                {
                    Success = false,
                    ErrorMessage = ex.Message
                });
            }
        }

    }
}
