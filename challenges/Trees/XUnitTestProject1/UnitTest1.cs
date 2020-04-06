using System;
using Trees.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinaryTree bt = new BinaryTree();

            Assert.IsType < BinaryTree >(bt);
        }

        [Fact]
        public void CanInstantiateSingleRootNode()
        {
            BinaryTree bt = new BinaryTree();
            Assert.NotNull(bt.Root);

        }

        [Fact]

        public void CanAddLeftChild()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 6;
            bst.Add(bt.Root, 3); 
            bst.Add(bt.Root, 10);

            Assert.Equal(3, bst.Root.LeftChild.Value);
            Assert.Equal(10, bst.Root.RightChild.Value);
        }

        [Fact]

        public void TranversePreOrder()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 6;
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 10);

            int[] array = bt.PreOrder(bt.Root);
            int[] expect = { 6, 3, 10 };
            Assert.Equal(expect, array);

        }

        [Fact]

        public void TranverseInOrder()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 6;
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 10);
            int[] array = bt.InOrder(bt.Root);
            int[] expected = { 3, 6, 10 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void TranversePostOrder()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 6;
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 10);
            int[] array = bt.PostOrder(bt.Root);
            int[] expected = {3,10,6};
            Assert.Equal(expected, array);
        }
    }
}
