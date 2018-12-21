using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Payload sent when a user unsubscribes from a presence channel
    /// See <c>https://pusher.com/docs/webhooks</c> for details.
    /// </summary>
    public class MemberRemovedPayload : BasePayload
    {
        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
