using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCatOrDogObjects()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animals Dog = new Animals();

            shelter.Enqueue(Dog);
            Assert.Equal(Dog, shelter.Front);
        }

        [Fact]
        public void CanAddMultipleCatOrDogObjects()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animals Dog = new Animals();
            Animals Cat = new Animals();

            shelter.Enqueue(Cat);
            shelter.Enqueue(Dog);
            shelter.Enqueue(Cat);
            shelter.Enqueue(Dog);

            Assert.Equal(Dog, shelter.Rear);
        }

        [Fact]
        public void CanDequeueEitherCatOrDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animals Dog = new Animals();
            Animals Cat = new Animals();

            shelter.Enqueue(Dog);
            shelter.Enqueue(Cat);
            shelter.Dequeue(Dog);

            Assert.Equal(Cat, shelter.Rear);
        }

        [Fact]
        
        public void ReturnsNullWhenNotCatOrDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animals Dog = new Animals();
            Animals Cat = new Animals();
            Animals Chicken = new Animals();

            shelter.Enqueue(Dog);
            shelter.Enqueue(Cat);
            Animals result = shelter.Dequeue(Chicken);

            Assert.Null(result);
        }

    }
}
