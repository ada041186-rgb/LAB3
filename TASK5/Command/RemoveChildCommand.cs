using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Command
{
    class RemoveChildCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _child;

        public RemoveChildCommand(LightElementNode parent, LightNode child)
        { _parent = parent; _child = child; }

        public void Execute() => _parent.Remove(_child);
        public void Undo() => _parent.Add(_child);
    }
}
