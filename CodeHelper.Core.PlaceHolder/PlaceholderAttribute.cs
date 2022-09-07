namespace CodeHelper.Core.PlaceHolder
{
    [System.AttributeUsage(System.AttributeTargets.Field |
                       System.AttributeTargets.Property)
    ]
    public class PlaceholderAttribute : System.Attribute
    {
        #region Properties        
        public string Text { get; set; } = "";
        public string Format { get; set; } = "";
        #endregion

        #region Constructors
        /// <summary>
        /// The placeholder, often {YOURFIELDNAME}
        /// </summary>
        /// <param name="text">string, required. The placeholer used in your text</param>
        /// <param name="format">string, optional: the format of the output, can be used to format numbers or dates,....  In case the value can't be formatted with the given value, the original value will be used (no error will be thrown)</param>
        public PlaceholderAttribute(string text, string format)
        {
            this.Text = text;
            this.Format = format;
        }
        #endregion
    }
}
