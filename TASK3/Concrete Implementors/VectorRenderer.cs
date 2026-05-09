using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3.Implementor;

namespace TASK3.Concrete_Implementors
{
    class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius) =>
            Console.WriteLine($"  Drawing Circle as vectors      (radius={radius})");

        public void RenderSquare(float side) =>
            Console.WriteLine($"  Drawing Square as vectors      (side={side})");

        public void RenderTriangle(float @base, float height) =>
            Console.WriteLine($"  Drawing Triangle as vectors    (base={@base}, height={height})");
    }
}
