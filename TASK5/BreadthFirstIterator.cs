using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5
{
    class BreadthFirstIterator : ILightNodeIterator
    {
        private readonly LightNode _root;
        private readonly Queue<LightNode> _queue = new();
        public LightNode Current { get; private set; } = null!;
        object IEnumerator.Current => Current;

        public BreadthFirstIterator(LightNode root) { _root = root; Reset(); }

        public bool MoveNext()
        {
            if (_queue.Count == 0) return false;
            Current = _queue.Dequeue();
            if (Current is LightElementNode el)
                foreach (var child in el.Children)
                    _queue.Enqueue(child);
            return true;
        }

        public void Reset() { _queue.Clear(); _queue.Enqueue(_root); }
        public void Dispose() { }
    }
}
