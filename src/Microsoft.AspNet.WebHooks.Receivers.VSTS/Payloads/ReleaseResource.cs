// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the resource that associated with <see cref="ReleaseCreatedPayload"/>, <see cref="ReleaseAbandonedPayload"/>
    /// </summary>
    public class ReleaseResource : BaseResource
    {
        /// <summary>
        /// The Release.
        /// </summary>
        [JsonProperty("release")]
        public Release Release { get; set; }

        /// <summary>
        /// The project.
        /// </summary>
        [JsonProperty("project")]
        public Project Project { get; set; }
    }
}
