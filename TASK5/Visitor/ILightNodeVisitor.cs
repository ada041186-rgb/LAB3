using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Visitor
{
    interface ILightNodeVisitor
    {
        void Visit(LightElementNode node);
        void Visit(LightTextNode node);
    }
}
