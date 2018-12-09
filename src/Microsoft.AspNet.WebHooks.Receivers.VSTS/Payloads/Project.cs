using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Information about a project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// The project Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The project name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
