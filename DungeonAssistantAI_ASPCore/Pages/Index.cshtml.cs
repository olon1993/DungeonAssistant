using DungeonAssistantAI_ASPCore.Models;
using DungeonAssistantAI_ASPCore.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DungeonAssistantAI_ASPCore.Pages
{
	public class IndexModel : PageModel
	{
        private readonly ILogger<IndexModel> _logger;
        private IDataAccessService _dataAccessService;
        private IOpenAiService _openAiService;


        public NoticeRowModel noticeRow { get; private set; } = new NoticeRowModel();

        public SingleImageRowModel singleImageRow { get; private set; } = new SingleImageRowModel();

        public ChatModel chatModel { get; set; } = new ChatModel();

        public IndexModel(IDataAccessService dataAccessService, IOpenAiService openAiService, ILogger<IndexModel> logger)
		{
            _dataAccessService = dataAccessService;
            _openAiService = openAiService;
            _logger = logger;
            LoadDefaultValues();
        }

        public async Task OnPost()
        {
            string systemMessage = Request.Form["SystemMessage"].ToString().Trim();
            string persona = Request.Form["Persona"].ToString().Trim();
            string prompt = Request.Form["Prompt"].ToString().Trim();

            if (String.IsNullOrEmpty(prompt))
            {
                return;
            }

            string response = await _openAiService.GetResponse(systemMessage, persona, prompt);
            chatModel = new ChatModel(response, systemMessage, persona);
        }

        private void LoadDefaultValues()
        {
            string strNotifyMessage = "Free Shipping for orders above $250";
            noticeRow = new(strNotifyMessage);
            singleImageRow = new SingleImageRowModel("singleImage.jpg");
            singleImageRow.ApplyTopPadding(2);
        }

    }
}
