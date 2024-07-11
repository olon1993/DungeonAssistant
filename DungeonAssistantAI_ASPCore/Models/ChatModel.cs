using Microsoft.AspNetCore.Mvc;

namespace DungeonAssistantAI_ASPCore.Models
{
    public class ChatModel : SmartRowModel
    {

        public string Response { get; set; } = "";
        public string Prompt { get; set; } = "";
        public string SystemMessage { get; set; } = "";
        public string Persona { get; set; } = "";

        public ChatModel()
        {

        }

        public ChatModel(string response, string systemMessage, string persona)
        {
            Response = response;
            SystemMessage = systemMessage;
            Persona = persona;
        }
    }
}
