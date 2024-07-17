namespace DungeonAssistantAI_ASPCore.Models
{
    public class SettingModel : DataObject
    {
        public string Name { get; set; }
        public List<AttributeModel> Attributes { get; set; }
    }
}
