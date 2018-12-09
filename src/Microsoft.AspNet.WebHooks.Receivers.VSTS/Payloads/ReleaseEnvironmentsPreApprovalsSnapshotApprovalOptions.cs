// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the approval options.
    /// </summary>
    public class ReleaseEnvironmentsPreApprovalsSnapshotApprovalOptions
    {
        /// <summary>
        /// Gets the RequiredApproverCount.
        /// </summary>
        [JsonProperty("requiredApproverCount")]
        public int RequiredApproverCount { get; set; }

        /// <summary>
        /// Gets the releaseCreatorCanBeApprover.
        /// </summary>
        [JsonProperty("releaseCreatorCanBeApprover")]
        public bool ReleaseCreatorCanBeApprover { get; set; }
    }
}
