using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace NewsLibrary.Model
{
    public class News
    {
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        public string MostVowels { get; set; }

        public void FindMostVolwes()
        {
            var r = new Regex("(a|A|e|E|i|I|o|O|u|U|y|Y|А|а|Я|я|У|у|Ю|ю|О|о|Е|е|Ё|ё|Э|э|И|и|Ы|ы)");
            char[] separators = new char[] { ' ', '.', ',', ':', ';', '?', '!', '>', '<', '$', '&', '%', '#', '@', '№', '*', '(', ')', '/', '\\', '\"', '+', '=','\r','\t' };
            var words = Description.Split(separators);
            int counter = 0;
            foreach (var word in words)
            {
                var currentCounter = r.Matches(word).Count;
                if(currentCounter > counter)
                {
                    counter = currentCounter;
                    MostVowels = word;
                }
            }
        }
    }
}
