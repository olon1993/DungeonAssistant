namespace DungeonAssistantAI_ASPCore.Models
{
    public class AttributeModel : DataObject
    {
        public string Name { get; set; }
        public Guid CampaignId { get; set; }
        public Guid SettingId { get; set; }
        public Guid SceneId { get; set; }
        public Guid PersonaId { get; set; }
        public string Value { get; set; }
    }
}
