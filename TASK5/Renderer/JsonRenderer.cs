using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TASK5.Renderer
{
    class JsonRenderer : IRenderer
    {
        public string RenderElement(string tagName, IReadOnlyList<string> cssClasses,
                                    IReadOnlyList<LightNode> children, int indent)
        {
            string pad = new(' ', indent * 2);
            string classes = cssClasses.Count > 0
                ? $"[{string.Join(", ", cssClasses.Select(c => $"\"{c}\""))}]"
                : "[]";

            var sb = new StringBuilder();
            sb.AppendLine($"{pad}{{");
            sb.AppendLine($"{pad}  \"tag\": \"{tagName}\",");
            sb.AppendLine($"{pad}  \"classes\": {classes},");
            sb.AppendLine($"{pad}  \"children\": [");

            for (int i = 0; i < children.Count; i++)
            {
                sb.Append(RenderNode(children[i], indent + 2));
                if (i < children.Count - 1) sb.Append(",");
                sb.AppendLine();
            }

            sb.AppendLine($"{pad}  ]");
            sb.Append($"{pad}}}");
            return sb.ToString();
        }

        public string RenderText(string text, int indent) =>
            new string(' ', indent * 2) + $"{{ \"text\": \"{text}\" }}";

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
