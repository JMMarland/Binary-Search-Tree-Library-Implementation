using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class BinSearchTree<KEY, VALUE> where KEY : IComparable
    {
        private TreeNode<KEY, VALUE> _root = null;

        public void Insert(KEY key, VALUE value)
        {
            if (_root == null)
            {
                _root = new TreeNode<KEY, VALUE>(key, value); ;
                return;
            }

            TreeNode<KEY, VALUE > currentNode = _root;
            bool isSearching = true;

            while (isSearching)
            {
                int comparison = currentNode.Key.CompareTo(key);

                if (comparison == 0)
                {
                    currentNode.Value = value;
                    return;
                }

                if (comparison > 0)
                {

                }
            }
        }
    }
}
