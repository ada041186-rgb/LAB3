using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Abstraction;
using TASK3.Implementor;

namespace TASK3.Refined_Abstractions
{
    class Circle : Shape
    {
        private readonly float _radius;

        public Circle(IRenderer renderer, float radius) : base(renderer) =>
            _radius = radius;

        public override void Draw() => Renderer.RenderCircle(_radius);
    }
}
