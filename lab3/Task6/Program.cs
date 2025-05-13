using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "book.txt";
        string[] lines = File.ReadAllLines(filePath);

        List<LightNode> htmlNodes = new List<LightNode>();

        int lineIndex = 0;
        foreach (var line in lines)
        {
            LightNode node = CreateHtmlElement(line, lineIndex);
            htmlNodes.Add(node);
            lineIndex++;
        }

        foreach (var node in htmlNodes)
        {
            Console.WriteLine(node.OuterHtml);
        }

        Console.WriteLine($"Memory size: {System.GC.GetTotalMemory(false)} bytes");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static LightNode CreateHtmlElement(string line, int lineIndex)
    {
        // Перший рядок має бути <h1>
        if (lineIndex == 0)
            return new LightElementNode("h1", line);

        // Якщо рядок менше 20 символів, це має бути <h2>
        if (line.Length < 20)
            return new LightElementNode("h2", line);

        // Якщо рядок починається з пробілу, це має бути <blockquote>
        if (line.StartsWith(" "))
            return new LightElementNode("blockquote", line);

        // В будь-якому іншому випадку, це <p>
        return new LightElementNode("p", line);
    }
}
