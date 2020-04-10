using SumOfOddBinaryTree.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetTheSumOfOddNum()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 12);
            bst.Add(bst.Root, 23);
            bst.Add(bst.Root, 9);

            int result = bt.SumofOddNum(bst);

            Assert.Equal(40, result);
        }

        [Fact]
        public void ExpectedFail()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 12);
            bst.Add(bst.Root, 23);
            bst.Add(bst.Root, 9);

            int result = bt.SumofOddNum(bst);

            Assert.NotEqual(3, result);
        }
    }
}
