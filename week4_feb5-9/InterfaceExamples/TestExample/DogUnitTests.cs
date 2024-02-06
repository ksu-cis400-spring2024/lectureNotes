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
        public void DogPeopleAgeTest(uint age, uint expPeopleAge)
        {
            //will finish on Wednesday
        }
    }
}