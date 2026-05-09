using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Renderer
{
    interface IRenderer
    {
        string RenderElement(string tagName, IReadOnlyList<string> cssClasses,
                             IReadOnlyList<LightNode> children, int indent);
        string RenderText(string text, int indent);
    }
}
