using Hashtables.Classes;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToTable()
        {
            Hashtable ht = new Hashtable();
            ht.Hash("kudoski is a");
            ht.Add("kudoski is a", "fool");
            bool result = ht.Contains("kudoski is a");
            Assert.True(result);
        }


        [Fact]
        public void CanRetrieveFromTableBasedOnKey()
        {
            Hashtable ht = new Hashtable();
            int num = ht.Hash("kudoski is a");
            ht.Add("kudoski is a", "fool");
            ht.Get("kudoski is a");
            Assert.Equal("fool", ht.Get("kudoski is a"));
        }


        [Fact]
        public void ReturnsNull()
        {
            Hashtable ht = new Hashtable();
            ht.Hash("kudoski is a");
            ht.Add("kudoski is a", "fool");
            ht.Get("mochiko is a");
            Assert.Null(ht.Get("mochiko is a"));
        }

        [Fact]
        public void CanHandleCollision()
        {
            Hashtable ht = new Hashtable();
            ht.Add("kudoski is a", "fool");
            ht.Add("kudoski is a", "cutie");

            Assert.Equal("cutie", ht.Get("kudoski is a"));
        }

        [Fact]
        public void CanGetValueFromBucketWithCollision()
        {
            Hashtable ht = new Hashtable();
            ht.Add("kudoski is a", "fool");
            ht.Add("kudoski is a", "cutie");

            Assert.Equal("cutie", ht.Get("kudoski is a"));
        }

        [Fact]
        public void CanHashKeyInRangeValue()
        {
            Hashtable ht = new Hashtable();
            int hashed = ht.Hash("abc");

            Assert.Equal(294, hashed);
        }

    }
}
