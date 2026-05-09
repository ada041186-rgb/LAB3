using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3.Implementor
{
    interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderSquare(float side);
        void RenderTriangle(float @base, float height);
    }
}
