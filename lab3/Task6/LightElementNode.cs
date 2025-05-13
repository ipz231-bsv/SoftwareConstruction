using System.Collections.Generic;

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public string Content { get; }
    public List<LightNode> Children { get; }

    public LightElementNode(string tagName, string content)
    {
        TagName = tagName;
        Content = content;
        Children = new List<LightNode>();
    }

    public override string OuterHtml
    {
        get
        {
            string innerHtml = string.Join("", Children.ConvertAll(child => child.OuterHtml));
            return $"<{TagName}>{innerHtml}{Content}</{TagName}>";
        }
    }
}
