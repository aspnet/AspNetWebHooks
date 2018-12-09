// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the post approvals snapshot.
    /// </summary>
    public class ReleaseEnvironmentsPostApprovalsSnapshot
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
    }
}
