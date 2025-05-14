public class LightImageElementNode : LightElementNode
{
    private IImageLoadStrategy _imageLoadStrategy;

    public string Href { get; set; }

    public LightImageElementNode(string tagName, DisplayType display, ClosingType closing, string href, IImageLoadStrategy imageLoadStrategy)
        : base(tagName, display, closing)
    {
        Href = href;
        _imageLoadStrategy = imageLoadStrategy;
    }

    public void LoadImage()
    {
        _imageLoadStrategy.LoadImage(Href);
    }

    public override string OuterHTML
    {
        get
        {
            return $"<img src=\"{Href}\" />";
        }
    }
}
