using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Payload sent when a channel becomes vacated
    /// See <c>https://pusher.com/docs/webhooks</c> for details.
    /// </summary>
    public class ChannelVacatedPayload
    {
        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}
