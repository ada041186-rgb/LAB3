using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Renderer
{
    class PlainTextRenderer : IRenderer
    {
        public string RenderElement(string tagName, IReadOnlyList<string> cssClasses,
                                    IReadOnlyList<LightNode> children, int indent)
        {
            var sb = new StringBuilder();
            foreach (var child in children)
                sb.Append(RenderNode(child, indent));
            return sb.ToString();
        }

        public string RenderText(string text, int indent) => text + " ";

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
