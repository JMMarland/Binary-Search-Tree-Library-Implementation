using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class BinSearchTree<KEY, VALUE> where KEY : IComparable
    {
        private TreeNode<KEY, VALUE> _root = null;

        public KeyValuePair<KEY, VALUE> Delete(KEY key)
        {
            TreeNode<KEY, VALUE> nodeToDelete = GetNode(key, _root);

            // NEEDS TO BE COMPLETED
        }

        public KeyValuePair<KEY, VALUE> Minimum()
        {
            return MinOfBranch(_root).KeyValuePair;
        }
        
        public KeyValuePair<KEY, VALUE> Maximum()
        {
            return MaxOfBranch(_root).KeyValuePair;
        }

        private TreeNode<KEY, VALUE> MinOfBranch(TreeNode<KEY, VALUE> currentNode)
        {
            if (currentNode.LeftChild == null)
                return currentNode;

            return MinOfBranch(currentNode.LeftChild);
        }
        
        private TreeNode<KEY, VALUE> MaxOfBranch(TreeNode<KEY, VALUE> currentNode)
        {
            if (currentNode.RightChild == null)
                return currentNode;

            return MaxOfBranch(currentNode.RightChild);
        }
        
        public KeyValuePair<KEY, VALUE>[] ToArray()
        {
            return TraverseTree(_root, new List<KeyValuePair<KEY, VALUE>>()).ToArray();
        }

        private List<KeyValuePair<KEY, VALUE>> TraverseTree(TreeNode<KEY, VALUE> currentNode, List<KeyValuePair<KEY, VALUE>> list)
        {
            if (currentNode == null)
                return list;

            list = TraverseTree(currentNode.LeftChild, list);
            list.Add(currentNode.KeyValuePair);
            return TraverseTree(currentNode.RightChild, list);
        }

        public VALUE Get(KEY key)
        {
            return GetNode(key, _root).Value;
        }

        private TreeNode<KEY, VALUE> GetNode(KEY key, TreeNode<KEY, VALUE> currentNode)
        {
            if (currentNode == null)
                throw new KeyNotFoundException();

            int comparison = currentNode.Key.CompareTo(key);

            if (comparison == 0)
                return currentNode;

            if (comparison < 0)
                return GetNode(key, currentNode.LeftChild);
            else
                return GetNode(key, currentNode.RightChild);
        }

        public bool KeyExists(KEY key)
        {
            TreeNode<KEY, VALUE> currentNode = _root;

            while (true)
            {
                if (currentNode == null)
                    return false;

                int comparison = currentNode.Key.CompareTo(key);

                if (comparison == 0)
                    return true;
                if (comparison < 0)
                    currentNode = currentNode.LeftChild;
                else
                    currentNode = currentNode.RightChild;
            }
        }
        
        public void Insert(KEY key, VALUE value)
        {
            TreeNode<KEY, VALUE> newNode = new TreeNode<KEY, VALUE>(key, value);

            if (_root == null)
            {
                _root = newNode;
                return;
            }

            TreeNode<KEY, VALUE> currentNode = _root;

            while (true)
            {
                int comparison = currentNode.Key.CompareTo(newNode.Key);

                if (comparison == 0)
                {
                    currentNode.AmendValue(newNode.Value);
                    return;
                }

                else if (comparison < 0)
                {
                    if (currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = newNode;
                        newNode.Parent = currentNode;
                        return;
                    }

                    currentNode = currentNode.LeftChild;
                }

                else
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = newNode;
                        newNode.Parent = currentNode;
                        return;
                    }

                    currentNode = currentNode.RightChild;
                }
            }
        }
    }
}
