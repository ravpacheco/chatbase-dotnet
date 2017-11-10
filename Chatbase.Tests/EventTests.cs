using Xunit;

namespace Chatbase.UnitTests
{
    public class ChatbaseEventUnitTests
    {
        private readonly Event _event;

        public ChatbaseEventUnitTests()
        {
            _event = new Event();
        }

        [Fact]
        public void DefaultIntent()
        {
            Assert.Equal("unknown", _event.Intent);
        }

        [Fact]
        public void DefaultsDoNotCoverAllRequiredFields()
        {
            Assert.False(_event.RequiredFields());
        }

        [Theory]
        [InlineData("stub-api-key")]
        public void GivingKeyToConstructorSetsOnInstance(string apiKey)
        {
            var @event = new Event(apiKey);
            Assert.Equal(@event.ApiKey, apiKey);
        }

        [Theory]
        [InlineData("stub-api-key", "stub-user-id", "stub-intent")]
        public void SettingRequiredPassesValidation(string key, string uid, string intent)
        {
            var @event = new Event
            {
                ApiKey = key,
                UserId = uid,
                Intent = intent,
            };

            Assert.True(@event.RequiredFields());
        }

        [Theory]
        [InlineData("stub-api-key")]
        public void GivingKeyToEventConstructor(string apikey)
        {
            var @event = new Chatbase.Event(apikey);
            Assert.Equal(@event.ApiKey, apikey);
        }
    }
}
