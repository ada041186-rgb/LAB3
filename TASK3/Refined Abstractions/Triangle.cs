using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Abstraction;
using TASK3.Implementor;

namespace TASK3.Refined_Abstractions
{
    class Triangle : Shape
    {
        private readonly float _base;
        private readonly float _height;

        public Triangle(IRenderer renderer, float @base, float height) : base(renderer)
        {
            _base = @base;
            _height = height;
        }

        public override void Draw() => Renderer.RenderTriangle(_base, _height);
    }
}
