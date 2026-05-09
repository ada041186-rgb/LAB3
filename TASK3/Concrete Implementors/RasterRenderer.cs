using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Implementor;

namespace TASK3
{
    class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius) =>
            Console.WriteLine($"  Drawing Circle as pixels       (radius={radius})");

        public void RenderSquare(float side) =>
            Console.WriteLine($"  Drawing Square as pixels       (side={side})");

        public void RenderTriangle(float @base, float height) =>
            Console.WriteLine($"  Drawing Triangle as pixels     (base={@base}, height={height})");
    }
}
