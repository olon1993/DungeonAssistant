namespace DungeonAssistantAI_ASPCore.Models
{
    public abstract class DataObject
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime LastAccessed { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
