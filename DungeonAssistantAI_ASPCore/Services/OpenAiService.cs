using OpenAI.Chat;
using OpenAI.Models;
using OpenAI;
using OpenAI.Assistants;

namespace DungeonAssistantAI_ASPCore
{
	public class OpenAiService : IOpenAiService
	{
        private const string KEY = "OPENAI_API_KEY";
        private OpenAIClient api;

        public OpenAiService()
        {
            string key = Environment.GetEnvironmentVariable(KEY, EnvironmentVariableTarget.User);
            api = new OpenAIClient(key);
        }

		public async Task<string> GetResponse(string systemMessage, string persona, string prompt)
        {
            var messages = new List<Message>
			{
				new Message(Role.System, systemMessage),
				new Message(Role.Assistant, persona),
                new Message(Role.User, prompt),
            };
			var chatRequest = new ChatRequest(messages, Model.GPT3_5_Turbo_16K);
            var response = await api.ChatEndpoint.GetCompletionAsync(chatRequest);
			var choice = response.FirstChoice;
			return choice.Message;
		}
    }
}
