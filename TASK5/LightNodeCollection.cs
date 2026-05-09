using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5
{
    class LightNodeCollection : IEnumerable<LightNode>
    {
        private readonly LightNode _root;
        private readonly bool _depthFirst;

        public LightNodeCollection(LightNode root, bool depthFirst = true)
        {
            _root = root;
            _depthFirst = depthFirst;
        }

        public IEnumerator<LightNode> GetEnumerator() =>
            _depthFirst
                ? new DepthFirstIterator(_root)
                : new BreadthFirstIterator(_root);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}