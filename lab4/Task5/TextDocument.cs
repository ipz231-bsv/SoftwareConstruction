public class TextDocument
{
    public string Text { get; set; }

    public TextDocument(string text)
    {
        Text = text;
    }

    public void ShowText()
    {
        Console.WriteLine(Text);
    }
}
