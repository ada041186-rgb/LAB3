using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Visitor
{
    class StatsVisitor : ILightNodeVisitor
    {
        public int ElementCount { get; private set; }
        public int TextCount { get; private set; }
        public int MaxDepth { get; private set; }
        private int _currentDepth;

        public void Visit(LightElementNode node)
        {
            ElementCount++;
            _currentDepth++;
            if (_currentDepth > MaxDepth) MaxDepth = _currentDepth;

            foreach (var child in node.Children)
                if (child is LightElementNode e) Visit(e);
                else if (child is LightTextNode t) Visit(t);

            _currentDepth--;
        }

        public void Visit(LightTextNode node) => TextCount++;

        public void PrintReport()
        {
            System.Console.WriteLine($"  Елементів:            {ElementCount}");
            System.Console.WriteLine($"  Текстових вузлів:     {TextCount}");
            System.Console.WriteLine($"  Максимальна глибина:  {MaxDepth}");
        }
    }
}
