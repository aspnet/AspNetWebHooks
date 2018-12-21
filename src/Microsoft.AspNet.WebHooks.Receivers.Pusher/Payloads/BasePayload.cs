using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Base object for all types of events.
    /// </summary>
    public abstract class BasePayload
    {
        /// <summary>
        /// The unix timestamp in milliseconds when the webhook was created. This allows you to detect delayed webhooks if necessary
        /// </summary>
        [JsonProperty("time_ms")]
        public long CreatedAt { get; set; }
    }
}
