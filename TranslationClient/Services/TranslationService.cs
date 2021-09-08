using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TranslationClient.Models;

namespace TranslationClient.Services
{
    public class TranslationService : ITranslationService
    {

        private readonly HttpClient _httpClient;

        public TranslationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TranslationData> TranslateSentences(TranslationData Translate)
        {
            try
            {
                var translationJson = new StringContent(JsonConvert.SerializeObject(Translate), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/Translation/TranslateSentences", translationJson);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    //return await JsonSerializer.DeserializeAsync<TranslationData>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return JsonConvert.DeserializeObject<TranslationData>(responseBody);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public async Task<TranslationData> TranslateText(TranslationData Translate)
        {
            try
            {
                var translationJson = new StringContent(JsonConvert.SerializeObject(Translate), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/Translation/TranslateText", translationJson);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    //return await JsonSerializer.DeserializeAsync<TranslationData>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return JsonConvert.DeserializeObject<TranslationData>(responseBody);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
