using techdemo_heigl_kaitoua.Components.Pages;
using Xunit;




namespace UnitTests
{
    public class CounterTest
    {
        [Fact]
        public void CounterShouldIncrementWhenIncrementCountIsCalled()
        {
            var counterComponent = new Counter();

           
            counterComponent.IncrementCount();

            Assert.Equal(1, counterComponent.currentCount);
        }
    }
}

   