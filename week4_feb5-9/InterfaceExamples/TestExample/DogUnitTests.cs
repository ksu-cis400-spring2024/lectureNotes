using System.ComponentModel;

namespace TestExample
{
    public class DogUnitTests
    {
        [Fact]
        public void DogLegDefaultTest()
        {
            Dog d = new();
            Assert.Equal(4u, d.Legs);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 15)]
        [InlineData(2, 24)]
        [InlineData(3, 24 + 1*5)]
        [InlineData(15, 24 + 13*5)]
        [InlineData(7, 24 + 5 * 5)]
        public void DogPeopleAgeTest(uint years, uint expectedPeopleYears)
        {
            //will finish on Wednesday
            Dog d = new() { Age = years};

            Assert.Equal(expectedPeopleYears, d.PeopleYears);
        }

        [Fact]
        public void CheckDogEqual()
        {
            List<Dog> dogs = new() { new Dog() { Age = 10, Legs = 3, Name = "Fido" }, new Dog() { Age = 5, Legs = 2, Name = "Rover" }};
            Assert.Contains(new Dog() { Age = 10, Legs = 3, Name = "Fido" }, dogs);
        }
    }
}