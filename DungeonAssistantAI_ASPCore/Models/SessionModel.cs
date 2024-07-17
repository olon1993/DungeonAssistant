namespace DungeonAssistantAI_ASPCore.Models
{
    public class SessionModel : DataObject
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public Guid CampaignId { get; set; }
        public Guid SettingId { get; set; }
        public Guid SceneId { get; set; }
        public List<PersonaModel> Personas { get; set; }
    }
}
