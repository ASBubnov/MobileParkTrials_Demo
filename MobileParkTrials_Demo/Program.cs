using Microsoft.Extensions.Configuration;
using NewsLibrary.Model;
using NewsLibrary.Services;

IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
IConfigurationRoot root = builder.Build();

Request request = new Request();
Console.Write("Введите ключевое слово: ");
request.SearchQuery = Console.ReadLine()!;

await NewsApiService.FindNews(request, root["NewsApiKey"]!);

Console.ReadKey();



