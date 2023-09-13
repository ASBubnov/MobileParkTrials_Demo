using NewsLibrary.Model;
using System.Text.Json;

namespace NewsLibrary.Clients
{
    public class NewsApiClient
    {
        List<string> Languages = new List<string>()
            {
                "en",
                "ru"
            };
        public async Task<List<News>> GetAsync(Request request, string key)
        { 
            List<News> result = new List<News>();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "my top app");
            foreach (var language in Languages)
            {
                var url = "https://newsapi.org/v2/everything?" +
                          $"q={request.SearchQuery}&" +
                          $"language={language}&" +
                          $"apiKey={key}";                
                var json = await client.GetStringAsync(url);
                Response response = JsonSerializer.Deserialize<Response>(json)!;
                result.AddRange(response.Articles);
            }
            return result;
        }
    }
}
