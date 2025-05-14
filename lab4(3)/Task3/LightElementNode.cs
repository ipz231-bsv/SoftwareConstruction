public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType Display { get; set; }
    public ClosingType Closing { get; set; }
    public List<string> CssClasses { get; set; }
    public List<LightNode> Children { get; set; }

    private EventObserver _eventObserver;

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
        _eventObserver = new EventObserver();
    }

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }

    public override string InnerHTML =>
        string.Join("", Children.Select(child => child.OuterHTML));

    public override string OuterHTML
    {
        get
        {
            string classAttribute = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (Closing == ClosingType.Single)
                return $"<{TagName}{classAttribute} />";

            return $"<{TagName}{classAttribute}>{InnerHTML}</{TagName}>";
        }
    }

    public void AddEventListener(string eventType, Action listener)
    {
        _eventObserver.AddEventListener(eventType, listener);
    }

    public void TriggerEvent(string eventType)
    {
        _eventObserver.TriggerEvent(eventType);
    }
}
