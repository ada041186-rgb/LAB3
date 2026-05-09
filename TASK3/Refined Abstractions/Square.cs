using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Abstraction;
using TASK3.Implementor;

namespace TASK3.Refined_Abstractions
{
    class Square : Shape
    {
        private readonly float _side;

        public Square(IRenderer renderer, float side) : base(renderer) =>
            _side = side;

        public override void Draw() => Renderer.RenderSquare(_side);
    }
}
