using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5
{

    class DepthFirstIterator : ILightNodeIterator
    {
        private readonly LightNode _root;
        private readonly Stack<LightNode> _stack = new();
        public LightNode Current { get; private set; } = null!;
        object IEnumerator.Current => Current;

        public DepthFirstIterator(LightNode root) { _root = root; Reset(); }

        public bool MoveNext()
        {
            if (_stack.Count == 0) return false;
            Current = _stack.Pop();
            if (Current is LightElementNode el)
                for (int i = el.Children.Count - 1; i >= 0; i--)
                    _stack.Push(el.Children[i]);
            return true;
        }

        public void Reset() { _stack.Clear(); _stack.Push(_root); }
        public void Dispose() { }
    }

}
