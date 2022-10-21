using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApp.Model;

namespace WebApp.Services
{
    public class JsonFileBookService
    {

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");
            }
        }

        public IEnumerable<Book> getBookRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Book[]>(filestream.ReadToEnd());
            }
        }
    }
}
