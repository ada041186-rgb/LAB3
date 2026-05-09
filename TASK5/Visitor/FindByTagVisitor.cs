using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Visitor
{
    class FindByTagVisitor : ILightNodeVisitor
    {
        private readonly string _tag;
        public List<LightElementNode> Results { get; } = new();

        public FindByTagVisitor(string tag) => _tag = tag.ToLower();

        public void Visit(LightElementNode node)
        {
            if (node.TagName.ToLower() == _tag) Results.Add(node);
            foreach (var child in node.Children)
                if (child is LightElementNode e) Visit(e);
                else if (child is LightTextNode t) Visit(t);
        }

        public void Visit(LightTextNode node) { }
    }
}
