using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz_patente
{
    public static class RichiesteApi
    {
        private static readonly string Url = "http://quizpatente.infy.uk";// metti sempre https se il sito lo supporta
        private static readonly string cookie = "__test=5e62e36a0fb833fe6a0f2e717c72f628";//da cambiare ogni giorno http://quizpatente.infy.uk/getArgomenti.php 
        private static readonly string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/135.0.0.0 Safari/537.36";
        
        public static async Task<List<Quiz>> GetQuizzes()
        {
            string url = $"{Url}/getQuizzes.php";
            
            using (HttpClient client = new HttpClient())
            {
             
                client.DefaultRequestHeaders.Add("Cookie",cookie);
                client.DefaultRequestHeaders.Add("User-Agent", userAgent);
             
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
             
                string json = await response.Content.ReadAsStringAsync();
                List<Quiz> quizzes = JsonSerializer.Deserialize<List<Quiz>>(json);
                return quizzes;
             
            }

        }


        
    }
}
