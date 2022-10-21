using System.Text.Json.Serialization;
using System.Text.Json;

namespace WebApp.Model
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int booK_id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("image")]
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }

    }
}
