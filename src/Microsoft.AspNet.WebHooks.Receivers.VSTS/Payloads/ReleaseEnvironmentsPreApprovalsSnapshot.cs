// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the pre approvals snapshot.
    /// </summary>
    public class ReleaseEnvironmentsPreApprovalsSnapshot
    {
        private readonly Collection<object> _approvals = new Collection<object>();

        /// <summary>
        /// Gets approvals.
        /// </summary>
        [JsonProperty("approvals")]
        public Collection<object> Approvals
        {
            get { return _approvals; }
        }

        /// <summary>
        /// Gets the approval options.
        /// </summary>
        [JsonProperty("approvalOptions")]
        public ReleaseEnvironmentsPreApprovalsSnapshotApprovalOptions ApprovalOptions { get; set; }
    }
}
