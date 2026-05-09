using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5
{
    class LightTextNode : LightNode
    {
        private readonly string _text;

        public LightTextNode(string text) => _text = text;

        public override string OuterHTML(int indent = 0) =>
            new string(' ', indent * 2) + _text;
    }
}
