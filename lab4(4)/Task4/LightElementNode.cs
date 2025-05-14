using System.Collections.Generic;
using System.Linq;

public enum DisplayType
{
    Block,
    Inline
}

public enum ClosingType
{
    Single,
    Pair
}

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType Display { get; set; }
    public ClosingType Closing { get; set; }
    public List<string> CssClasses { get; set; }
    public List<LightNode> Children { get; set; }

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
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
}

public abstract class LightNode
{
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }
}

public class LightTextNode : LightNode
{
    public string Text { get; set; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public override string OuterHTML => Text;
    public override string InnerHTML => Text;
}
