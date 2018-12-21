using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Payload sent when a client event is sent on any private or presence channel
    /// See <c>https://pusher.com/docs/webhooks</c> for details.
    /// </summary>
    public class ClientEventPayload : BasePayload
    {
        /// <summary>
        /// Name of the channel the event was published on
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Data associated with the event
        /// </summary>
        [JsonProperty("data")]
        public JObject Data { get; set; }

        /// <summary>
        /// socket_id of the sending socket
        /// </summary>
        [JsonProperty("socket_id")]
        public string SocketId { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
