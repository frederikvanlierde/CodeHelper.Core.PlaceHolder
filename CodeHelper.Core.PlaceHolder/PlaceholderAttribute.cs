namespace CodeHelper.Core.PlaceHolder
{
    [System.AttributeUsage(System.AttributeTargets.Field |
                       System.AttributeTargets.Property)
    ]
    public class PlaceholderAttribute : System.Attribute
    {
        #region Properties        
        public string Text { get; set; } = "";
        #endregion

        #region Constructors
        public PlaceholderAttribute(string text)
        {
            this.Text = text;
        }
        #endregion
    }
}
