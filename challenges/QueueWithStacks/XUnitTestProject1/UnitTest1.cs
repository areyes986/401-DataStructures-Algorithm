using QueueWithStacks.Classes;
using System;
using System.Collections;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueToPsuedoQueue()
        {
            PsuedoQueue ps = new PsuedoQueue();
            ps.Enqueue(3);
            ps.Enqueue(4);
            ps.Enqueue(6);

            int number = ps.Stack1.Peek();
            Assert.Equal(3, number);
        }

        [Fact]
        public void CanEnqueueOneToPsuedoQueue()
        {
            PsuedoQueue ps = new PsuedoQueue();
            ps.Enqueue(3);

            int number = ps.Stack1.Peek();
            Assert.Equal(3, number);
        }

        [Fact]
        public void CanDequeueFromPsuedoQueue()
        {
            PsuedoQueue ps = new PsuedoQueue();
            ps.Enqueue(3);
            ps.Enqueue(4);
            ps.Enqueue(6);

            int number = ps.Dequeue();
            Assert.Equal(3, number);
        }

        [Fact]

        public void RaisesExceptionWhenPoppingFromEmptyQueue()
        {
            PsuedoQueue ps = new PsuedoQueue();

            Exception exception = Record.Exception(() => ps.Dequeue());
            Assert.IsType<Exception>(exception);



        }

    }
}
