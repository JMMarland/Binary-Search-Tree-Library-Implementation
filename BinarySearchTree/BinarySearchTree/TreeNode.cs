using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    internal class TreeNode<KEY, VALUE>
    {
        public KEY Key => _key;
        private KEY _key;
        public VALUE Value;
        
        public TreeNode<KEY, VALUE> Parent = null;
        public TreeNode<KEY, VALUE> LeftChild = null;
        public TreeNode<KEY, VALUE> RightChild = null;

        public TreeNode(KEY key, VALUE value)
        {
            _key = key;
            Value = value;
        }
    }
}
