using NewsLibrary.Clients;
using NewsLibrary.Model;

namespace NewsLibrary.Services
{
    public class NewsApiService
    {
        public static async Task FindNews(Request request, string key)
        {
            var client = new NewsApiClient();
            var news = await client.GetAsync(request, key);
            foreach (var item in news)
            {
                item.FindMostVolwes();
                Console.WriteLine($"Фрагмент новости:{item.Description}");
                Console.WriteLine($"Слово с наибольшим кол-ом гласных: {item.MostVowels} \n");
            }
        }
        
    }
}
