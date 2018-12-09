// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the environment options.
    /// </summary>
    public class ReleaseEnvironmentsEnvironmentOptions
    {
        /// <summary>
        /// Gets the EmailNotificationType.
        /// </summary>
        [JsonProperty("emailNotificationType")]
        public string EmailNotificationType { get; set; }

        /// <summary>
        /// Gets the EmailRecipients.
        /// </summary>
        [JsonProperty("emailRecipients")]
        public string EmailRecipients { get; set; }

        /// <summary>
        /// Gets the SkipArtifactsDownload.
        /// </summary>
        [JsonProperty("skipArtifactsDownload")]
        public bool SkipArtifactsDownload { get; set; }

        /// <summary>
        /// Gets the TimeoutInMinutes.
        /// </summary>
        [JsonProperty("timeoutInMinutes")]
        public int TimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets the EnableAccessToken.
        /// </summary>
        [JsonProperty("enableAccessToken")]
        public bool EnableAccessToken { get; set; }
    }
}
