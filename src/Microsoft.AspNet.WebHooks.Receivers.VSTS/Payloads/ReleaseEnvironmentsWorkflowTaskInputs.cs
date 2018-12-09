// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the inputs of workflow task.
    /// </summary>
    public class ReleaseEnvironmentsWorkflowTaskInputs
    {
        /// <summary>
        /// Gets the ConnectedServiceName.
        /// </summary>
        [JsonProperty("ConnectedServiceName")]
        public string ConnectedServiceName { get; set; }

        /// <summary>
        /// Gets the WebSiteName.
        /// </summary>
        [JsonProperty("WebSiteName")]
        public string WebSiteName { get; set; }

        /// <summary>
        /// Gets the WebSiteLocation.
        /// </summary>
        [JsonProperty("WebSiteLocation")]
        public string WebSiteLocation { get; set; }

        /// <summary>
        /// Gets the Slot.
        /// </summary>
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        /// <summary>
        /// Gets the Package.
        /// </summary>
        [JsonProperty("Package")]
        public string Package { get; set; }
    }
}
