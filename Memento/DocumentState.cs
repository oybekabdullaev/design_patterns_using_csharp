namespace DesignPatterns.Memento
{
    class DocumentState
    {
        public readonly string Content;
        public readonly string FontName;
        public readonly int FontSize;

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    } 
}