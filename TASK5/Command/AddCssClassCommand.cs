using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5.Command
{
    class AddCssClassCommand : ICommand
    {
        private readonly LightElementNode _node;
        private readonly string _cssClass;

        public AddCssClassCommand(LightElementNode node, string cssClass)
        { _node = node; _cssClass = cssClass; }

        public void Execute()
        {
            if (!_node.CssClasses.Contains(_cssClass))
                _node.CssClasses.Add(_cssClass);
        }

        public void Undo() => _node.CssClasses.Remove(_cssClass);
    }
}
