using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Implementor;

namespace TASK3.Abstraction
{
    abstract class Shape
    {
        protected IRenderer Renderer;

        protected Shape(IRenderer renderer) => Renderer = renderer;

        public abstract void Draw();

        public void SetRenderer(IRenderer renderer) => Renderer = renderer;
    }
}
