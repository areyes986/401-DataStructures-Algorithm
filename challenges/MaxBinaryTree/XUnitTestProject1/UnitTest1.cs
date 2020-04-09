using MaxBinaryTree.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetTheMaxValueFromTree()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 12);
            bst.Add(bst.Root, 23);
            bst.Add(bst.Root, 9);

            int result = bt.FindMaximumValue(bst);

            Assert.Equal(23, result);
        }

        [Fact]
        public void FailedIfNotMaxValueFromTree()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 12);
            bst.Add(bst.Root, 23);
            bst.Add(bst.Root, 9);

            int result = bt.FindMaximumValue(bst);

            Assert.NotEqual(5, result);
        }
    }
}
