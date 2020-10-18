using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    internal class TreeNode<KEY, VALUE>
    {
        private KeyValuePair<KEY, VALUE> _pair;

        public KeyValuePair<KEY, VALUE> KeyValuePair => _pair;
        
        public KEY Key => _pair.Key;
        public VALUE Value => _pair.Value;
        
        public TreeNode<KEY, VALUE> Parent = null;
        public TreeNode<KEY, VALUE> LeftChild = null;
        public TreeNode<KEY, VALUE> RightChild = null;

        public TreeNode(KEY key, VALUE value)
        {
            _pair = new KeyValuePair<KEY, VALUE>(key, value);
        }

        public void AmendValue(VALUE value)
        {
            _pair = new KeyValuePair<KEY, VALUE>(_pair.Key, value);
        }
    }
}
