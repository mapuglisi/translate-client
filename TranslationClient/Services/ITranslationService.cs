using System.Threading.Tasks;
using TranslationClient.Models;

namespace TranslationClient.Services
{
    /// <summary>
    /// An interface for the translation service
    /// </summary>
    public interface ITranslationService
    {
        /// <summary>
        /// A signature method to translate text to the target language as sentences
        /// </summary>
        /// <param name="Translation"></param>
        /// <returns></returns>
        Task<TranslationData> TranslateSentences(TranslationData Translation);

        /// <summary>
        /// A signature method to translate text to the target language
        /// </summary>
        /// <param name="Translation"></param>
        /// <returns></returns>
        Task<TranslationData> TranslateText(TranslationData Translation);
    }
}
