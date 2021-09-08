using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using TranslationClient.Models;
using TranslationClient.Services;

namespace TranslationClient.Pages
{
    public partial class Index
    {

        /// <summary>
        /// 
        /// </summary>
        protected string Message = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [Inject]
        public ITranslationService TranslationService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TranslationData Translation { get; set; } = new TranslationData();

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        protected void HandleInvalidRequest()
        {
            Message = "Failed to submit translation";
        }

    }
}
