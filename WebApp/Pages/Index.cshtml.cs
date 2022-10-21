using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;
using WebApp.Services;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        JsonFileBookService BookService;

        // Need variable for Book Record
        public IEnumerable<Book> Books;


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFileBookService services)
        {
            _logger = logger;
            BookService = services;

        }

        public void OnGet()
        {
            Books = BookService.getBookRecord();
        }
    }
}
