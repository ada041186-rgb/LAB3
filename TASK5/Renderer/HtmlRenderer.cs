using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Renderer
{
    class HtmlRenderer : IRenderer
    {
        public string RenderElement(string tagName, IReadOnlyList<string> cssClasses,
                                    IReadOnlyList<LightNode> children, int indent)
        {
            string pad = new(' ', indent * 2);
            string classAttr = cssClasses.Count > 0
                ? $" class=\"{string.Join(" ", cssClasses)}\""
                : "";

            var sb = new StringBuilder();
            sb.AppendLine($"{pad}<{tagName}{classAttr}>");
            foreach (var child in children)
                sb.AppendLine(RenderNode(child, indent + 1));
            sb.Append($"{pad}</{tagName}>");
            return sb.ToString();
        }

        public string RenderText(string text, int indent) =>
            new string(' ', indent * 2) + text;

        private string RenderNode(LightNode node, int indent)
        {
            if (node is LightElementNode el)
                return RenderElement(el.TagName, el.CssClasses, el.Children, indent);
            if (node is LightTextNode)
                return RenderText(node.OuterHTML().Trim(), indent);
            return "";
        }
    }
}
