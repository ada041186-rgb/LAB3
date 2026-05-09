using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.State
{
    class HoveredState : IElementState
    {
        public string Handle(LightElementNode ctx) =>
            $"<{ctx.TagName}> — стан: Hovered (підсвічений)";
    }
}
