using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString()
        {
            return $"{nameof(Content)}: {Content}, " +
                   $"{nameof(FontName)}: {FontName}, " +
                   $"{nameof(FontSize)}: {FontSize}";
        }
    }
}
