// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the resource that associated with <see cref="ReleaseDeploymentApprovalCompletedPayload"/>
    /// </summary>
    public class ReleaseDeploymentApprovalCompletedResource : BaseResource
    {
        /// <summary>
        /// The Approval.
        /// </summary>
        [JsonProperty("approval")]
        public Approval Approval { get; set; }

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
