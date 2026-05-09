using System;
using System.Collections.Generic;
using System.Text;

namespace TASK5
{
    abstract class LightNode
    {
        public abstract string OuterHTML(int indent = 0);

        public string Render()
        {
            OnBeforeRender();
            string html = OuterHTML();
            OnAfterRender();
            return html;
        }

        protected virtual void OnBeforeRender() { }
        protected virtual void OnAfterRender() { }
    }
}