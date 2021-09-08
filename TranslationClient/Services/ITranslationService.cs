using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslationClient.Models;

namespace TranslationClient.Services
{
    public interface ITranslationService
    {
        Task<TranslationData> TranslateSentences(TranslationData Translation);

        Task<TranslationData> TranslateText(TranslationData Translation);
    }
}
