class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
        div.CssClasses.Add("container");

        var p = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
        p.CssClasses.Add("text");

        var text = new LightTextNode("Привіт із LightHTML!");
        p.AddChild(text);

        div.AddChild(p);

        IImageLoadStrategy fileSystemStrategy = new FileSystemImageLoadStrategy();
        IImageLoadStrategy networkStrategy = new NetworkImageLoadStrategy();

        var image1 = new LightImageElementNode("img", DisplayType.Block, ClosingType.Single, "file:///path/to/image.jpg", fileSystemStrategy);
        var image2 = new LightImageElementNode("img", DisplayType.Block, ClosingType.Single, "http://example.com/image.jpg", networkStrategy);

        image1.LoadImage();
        image2.LoadImage();

        Console.WriteLine("InnerHTML:");
        Console.WriteLine(div.InnerHTML);

        Console.WriteLine("\nOuterHTML:");
        Console.WriteLine(div.OuterHTML);

        Console.ReadLine();
    }
}
