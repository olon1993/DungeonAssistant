namespace DungeonAssistantAI_ASPCore.Models
{
    public abstract class SmartRowModel
    {
        public string CssClass { get; private set; } = "";

        private string _cssTopPadding = "";
        private string _cssBottomPadding = "";

        private void ApplyPadding()
        {
            CssClass = _cssTopPadding + " " + _cssBottomPadding;
        }

        internal void ApplyTopPadding(int pd = 1)
        {
            if (pd > 5 || pd < 0)
            {
                throw new Exception("_cssBottomPadding Length Should be between 0 and 5");
            }

            _cssTopPadding = "pt-" + pd.ToString();
            ApplyPadding();
        }

        internal void ApplyBottomPadding(int pd = 1)
        {
            if (pd > 5 || pd < 0)
            {
                throw new Exception("_cssBottomPadding Length Should be between 0 and 5");
            }

            _cssBottomPadding = "pt-" + pd.ToString();
            ApplyPadding();
        }
    }
}
