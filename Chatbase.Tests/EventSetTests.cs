using Xunit;

namespace Chatbase.UnitTests
{
    public class ChatbaseEventSetUnitTests
    {
        public ChatbaseEventSetUnitTests() { }

        [Theory]
        [InlineData("api-key")]
        public void KeyToConstructorPropagatesToInstance(string apiKey)
        {
            var eventSet = new EventSet(apiKey);
            Assert.Equal(apiKey, eventSet.ApiKey);
        }

        [Theory]
        [InlineData("api-key")]
        public void EventsMadeFromSetContainKeyGivenToConstructor(string apiKey)
        {
            var set = new EventSet(apiKey);
            var @event = set.NewEvent();
            Assert.Equal(apiKey, @event.ApiKey);
            set.Add(@event);
            Assert.Equal(1, set.GetEvents().Count);
        }
    }
}
