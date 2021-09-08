using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using TranslationClient.Models;
using TranslationClient.Services;

namespace TranslationClient.Pages
{
    /// <summary>
    /// The main and only page, given that this is a single page application
    /// </summary>
    public partial class Index
    {

        /// <summary>
        /// A message to be displayed when an error occurs
        /// </summary>
        protected string Message = string.Empty;

        /// <summary>
        /// The translation service to be used
        /// </summary>
        [Inject]
        public ITranslationService TranslationService { get; set; }

        /// <summary>
        /// The translation data
        /// </summary>
        public TranslationData Translation { get; set; } = new TranslationData();

        /// <summary>
        /// A task that runs the injected service translation function
        /// </summary>
        /// <returns></returns>
        protected async Task TranslateText()
        {
            var res = await TranslationService.TranslateText(Translation);

            if (res != null)
            {
                Translation = res;
            }
            else
            {
                Message = "Something went wrong";
            }
        }

        /// <summary>
        /// A basic method to handle invalid requests
        /// </summary>
        protected void HandleInvalidRequest()
        {
            Message = "Failed to submit translation";
        }

    }
}
