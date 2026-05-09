using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.State
{
    interface IElementState
    {
        string Handle(LightElementNode context);
    }
}
