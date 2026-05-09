using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.State
{
    class DisabledState : IElementState
    {
        public string Handle(LightElementNode ctx) =>
            $"<{ctx.TagName}> — стан: Disabled (неактивний)";
    }
}
