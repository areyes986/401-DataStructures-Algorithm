using StacksAndQueues.Classes;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushIntoTheStack()
        {
            Stack stack = new Stack();
            stack.Push(3);
            int number = stack.Peek();
            Assert.Equal(3, number);
        }

        [Fact]
        public void CanPushMultipleIntoTheStack()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);

            int number = stack.Peek();
            Assert.Equal(7, number);
        }
        
        [Fact]

        public void CanPopOffTheStack()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            int number = stack.Pop();
            Assert.Equal(7, number);
        }

        [Fact]
        public void CanEmptyAStackAfterPops()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            bool result = stack.IsEmpty();
            Assert.True(result);
        }

        [Fact]

        public void CanPeekNextItem()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Pop();

            int result = stack.Peek();
            Assert.Equal(5, result);
        }

        [Fact]
        public void CanInstantiateEmptyStack()
        {
            Stack stack = new Stack();
            bool result = stack.IsEmpty();
            Assert.True(result);
        }

        [Fact]

        public void RaisesExceptionWhenPopOrPeekOnEmpty()
        {
            Stack stack = new Stack();
            Exception exception = Record.Exception(() => stack.Peek());
            Assert.IsType<Exception>(exception);
        }

        [Fact]
        public int CanEnqueueIntoQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);

            int number = queue.Peek();
            Assert.Equal(3, number);

        }
    }
}
