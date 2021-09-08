﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationClient.Models
{
    public class TranslationData
    {
        /// <summary>
        /// The language the original text is is
        /// </summary>
        [Required]
        [Display(Name = "Source language")]
        public SupportedLanguages sourceLanguage { get; set; } = SupportedLanguages.English;

        /// <summary>
        /// The desired language for the translation
        /// </summary>
        [Required]
        [Display(Name = "Target language")]
        public SupportedLanguages targetLanguage { get; set; } = SupportedLanguages.French;

        /// <summary>
        /// The original text
        /// </summary>
        [Required]
        [Display(Name = "Source text")]
        public string OriginalText { get; set; }

        /// <summary>
        /// The translated text
        /// </summary>
        public string TranslatedText { get; set; }

        /// <summary>
        /// The translated text as sentences
        /// </summary>
        public IEnumerable<string> TranslatedSentences { get; set; }
    }
}
