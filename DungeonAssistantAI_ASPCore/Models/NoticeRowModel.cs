namespace DungeonAssistantAI_ASPCore.Models
{
    public class NoticeRowModel : SmartRowModel
    {
        public NoticeRowModel()
        {
            
        }

        public NoticeRowModel(string strMessage)
        {
            this.NotifyText = strMessage;
        }

        public string NotifyText { get; private set; } = "";

    }
}
