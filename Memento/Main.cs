using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    static class Main
    {
        public static void Test()
        {
            var document = new Document();
            var history = new DocumentHistory();

            document.Content = "Hello";

            history.Push(document.CreateState());
            document.FontName = "Font 1";

            history.Push(document.CreateState());
            document.FontSize = 14;

            Console.WriteLine(document);

            document.Restore(history.Pop());
            Console.WriteLine(document);

            document.Restore(history.Pop());
            Console.WriteLine(document);
        }
    }
}
