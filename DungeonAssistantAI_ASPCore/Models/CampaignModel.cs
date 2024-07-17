namespace DungeonAssistantAI_ASPCore.Models
{
    public class CampaignModel : DataObject
    {
        public string Name { get; set; }
        List<AttributeModel> Attributes { get; set; }
    }
}
