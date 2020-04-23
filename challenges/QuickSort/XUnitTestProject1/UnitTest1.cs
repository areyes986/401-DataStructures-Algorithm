using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            int[] arr = { 5, 4, 3, 2, 12 };
            QuickSort.Program.QuickSort(arr, 0, arr.Length - 1);

            int[] expect = { 2, 3, 4, 5, 12 };
            Assert.Equal(expect, arr);
        }

        [Fact]
        public void ShouldFail()
        {
            int[] arr = { 5, 4, 3, 2, 12 };
            QuickSort.Program.QuickSort(arr, 0, arr.Length - 1);

            int[] expect = { 5, 4, 3, 2, 12 };
            Assert.NotEqual(expect, arr);
        }

        [Fact]
        public void CannotSortEmptyArr()
        {
            int[] arr = { };
            QuickSort.Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.Empty(arr);
        }

        [Fact]
        public void CanSortWithDuplicateNumbers()
        {
            int[] arr = { 5, 4, 3 ,3 ,2, 12 };
            QuickSort.Program.QuickSort(arr, 0, arr.Length - 1);
            int[] expect = { 2, 3,3, 4, 5, 12 };

            Assert.Equal(expect, arr);
        }




    }
}
