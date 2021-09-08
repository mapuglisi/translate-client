using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TranslationClient.Models;

namespace TranslationClient.Services
{
    /// <summary>
    /// The translation service
    /// </summary>
    public class TranslationService : ITranslationService
    {

        private readonly HttpClient _httpClient;

        /// <summary>
        /// A simple constructor for the translation service that receives an injected <see cref="HttpClient"/>
        /// </summary>
        /// <param name="httpClient"></param>
        public TranslationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// An interface method implementation to get the desired text translated to a target language as sentences
        /// </summary>
        /// <param name="Translate">The translation data</param>
        /// <returns>A <see cref="TranslationData"/> containing the translation in the <see cref="TranslationData.TranslatedSentences"/></returns>
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

        /// <summary>
        /// An interface method implementation to get the desired text translated to a target language
        /// </summary>
        /// <param name="Translate">The translation data</param>
        /// <returns>A <see cref="TranslationData"/> containing the translation in the <see cref="TranslationData.TranslatedText"/></returns>
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
