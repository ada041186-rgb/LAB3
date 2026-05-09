using System;
using System.Collections.Generic;
using System.Text;

namespace TASK5
{
    class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        public List<string> CssClasses { get; } = new();

        private readonly List<LightNode> _children = new();

        public int ChildCount => _children.Count;

        public LightElementNode(
            string tagName,
            DisplayType display = DisplayType.Block,
            ClosingType closing = ClosingType.WithClosingTag,
            IEnumerable<string>? cssClasses = null)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            if (cssClasses != null) CssClasses.AddRange(cssClasses);
        }

        public LightElementNode Add(LightNode child)
        {
            if (Closing == ClosingType.SelfClosing)
                throw new InvalidOperationException($"<{TagName}/> is self-closing and cannot have children.");
            _children.Add(child);
            return this;
        }

        public LightElementNode AddText(string text) => Add(new LightTextNode(text));


        public string InnerHTML(int indent = 0)
        {
            var sb = new StringBuilder();
            foreach (var child in _children)
            {
                sb.AppendLine(child.OuterHTML(indent));
            }
            if (sb.Length > 0 && sb[^1] == '\n') sb.Length--;
            return sb.ToString();
        }


        public override string OuterHTML(int indent = 0)
        {
            string pad = new(' ', indent * 2);
            string classAttr = CssClasses.Count > 0
                ? $" class=\"{string.Join(" ", CssClasses)}\""
                : "";

            if (Closing == ClosingType.SelfClosing)
                return $"{pad}<{TagName}{classAttr}/>";

            var sb = new StringBuilder();
            sb.AppendLine($"{pad}<{TagName}{classAttr}>");

            foreach (var child in _children)
                sb.AppendLine(child.OuterHTML(indent + 1));

            sb.Append($"{pad}</{TagName}>");
            return sb.ToString();
        }
    }
}
