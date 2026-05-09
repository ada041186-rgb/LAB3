using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Visitor
{
    class PlainTextVisitor : ILightNodeVisitor
    {
        private readonly StringBuilder _sb = new();
        public string Result => _sb.ToString().Trim();

        public void Visit(LightElementNode node)
        {
            foreach (var child in node.Children)
                if (child is LightElementNode e) Visit(e);
                else if (child is LightTextNode t) Visit(t);
        }

        public void Visit(LightTextNode node) =>
            _sb.Append(node.OuterHTML().Trim() + " ");
    }
}
