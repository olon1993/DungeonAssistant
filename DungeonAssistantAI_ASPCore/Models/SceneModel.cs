namespace DungeonAssistantAI_ASPCore.Models
{
    public class SceneModel : DataObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AttributeModel> Attributes { get; set; }
    }
}
