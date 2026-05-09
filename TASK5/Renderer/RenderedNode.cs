using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Renderer
{
    class RenderedNode
    {
        private readonly LightElementNode _node;
        private IRenderer _renderer;

        public RenderedNode(LightElementNode node, IRenderer renderer)
        {
            _node = node;
            _renderer = renderer;
        }

        public void SetRenderer(IRenderer renderer) => _renderer = renderer;

        public string Render() =>
            _renderer.RenderElement(
                _node.TagName,
                _node.CssClasses,
                _node.Children,
                0);
    }
}