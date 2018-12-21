using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Payload sent when a channel becomes occupied
    /// See <c>https://pusher.com/docs/webhooks</c> for details.
    /// </summary>
    public class ChannelOccupiedPayload
    {
        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}
