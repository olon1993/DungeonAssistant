namespace DungeonAssistantAI_ASPCore.Models
{
    public class SingleImageRowModel : SmartRowModel
    {
        public string ImagePath { get; private set; } = "";

        public SingleImageRowModel()
        {
            
        }

        public SingleImageRowModel(string strImgPath)
        {
            ImagePath = @"Images\" + strImgPath;
        }
    }
}
