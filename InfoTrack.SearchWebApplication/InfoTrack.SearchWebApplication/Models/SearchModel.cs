using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.SearchWebApplication.Models
{
    /// <summary>
    /// The search model 
    /// </summary>
    public class SearchModel
    {
        [Required(ErrorMessage = "Please enter key words to search")]
        [MaxLength(100, ErrorMessage="Please limit your search key words to not exceed 100 characters")]
        public string SearchString { get; set; }

        [Required(ErrorMessage = "Please select which search engine you want to search in")]
        public SearchEngineTypeEnum SearchEngineType { get; set; }
    }
}
