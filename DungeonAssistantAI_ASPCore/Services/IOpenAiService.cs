namespace DungeonAssistantAI_ASPCore
{
    public interface IOpenAiService
    {
        Task<string> GetResponse(string systemMessage, string persona, string prompt);
    }
}
