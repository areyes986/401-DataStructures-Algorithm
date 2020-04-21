using BreadthFirst.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanListOutAllValuesInTree()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 9;
            bst.Add(bt.Root, 4);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 8);
            bst.Add(bt.Root, 1);

            List<int> values = BinaryTree.BreadthFirst(bt);
            List<int> expected = new List<int> {9, 4, 1, 6, 8};

            Assert.Equal(expected, values);
        }
        [Fact]
        public void ExpectedError()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 9;
            bst.Add(bt.Root, 4);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 8);
            bst.Add(bt.Root, 1);

            List<int> values = BinaryTree.BreadthFirst(bt);
            List<int> expected = new List<int> { 9, 1, 4, 6, 8 };

            Assert.NotEqual(expected, values);
        }
    }
}
