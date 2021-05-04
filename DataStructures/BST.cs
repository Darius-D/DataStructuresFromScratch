using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BST
    {
        private TreeNode root;

        public void Insert(int value)
        {
            // creating a node
            TreeNode newNode = new TreeNode();
            newNode.value = value;
            newNode.left = newNode.right = null;

            if (root == null)
            {
                // handle the base case where the tree is empty
                root = newNode;
            }
            else
            {
                TreeNode current = root;
                while (true)
                {
                    if (value > current.value)
                    {
                        if (current.right == null)
                        {
                            current.right = newNode;
                            break;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                    else
                    {
                        if (current.left == null)
                        {
                            current.left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                }
            }
        }

        public bool Search(int value)
        {
            TreeNode current = root;
            while (current != null)
            {
                if (current.value == value)
                {
                    return true;
                }
                else if (current.value < value)
                {
                    current = current.right;
                }
                else
                {
                    current = current.left;
                }
            }

            return false;
        }

        public void Delete(int value)
        {
            if (root == null)
            {
                return;
            }

            if (root.value == value)
            {
                TreeNode smallestInRight = GetSmallestNode(root.right);
                if (smallestInRight != null)
                {
                    Delete(smallestInRight.value);
                    root.value = smallestInRight.value;
                }
                else
                {
                    root = root.left;
                }
            }

            TreeNode current = root;
            TreeNode prev = null;
            bool isLeft = false;
            while (current != null)
            {
                if (current.value > value)
                {
                    prev = current;
                    isLeft = true;
                    current = current.left;
                }
                else if(current.value < value)
                {
                    prev = current;
                    isLeft = false;
                    current = current.right;
                }
                else
                {
                    TreeNode smallestInRightSubTree = GetSmallestNode(current.right);
                    if(smallestInRightSubTree != null)
                    {
                        Delete(smallestInRightSubTree.value);
                        current.value = smallestInRightSubTree.value;
                    }
                    else
                    {
                        if (isLeft)
                        {
                            prev.left = current.left;
                        }
                        else
                        {
                            prev.right = current.left;
                        }
                    }

                    break;
                }
            }
        }

        private TreeNode GetSmallestNode(TreeNode root)
        {
            if(root == null)
            {
                return null;
            }

            TreeNode curr = root;
            while (curr.left != null)
            {
                curr = curr.left;
            }

            return curr;
        }
    }
}
