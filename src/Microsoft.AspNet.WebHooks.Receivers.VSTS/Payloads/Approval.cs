// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes approval.
    /// </summary>
    public class Approval
    {
        /// <summary>
        /// Gets the approval identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the revision.
        /// </summary>
        [JsonProperty("revision")]
        public int Revision { get; set; }

        /// <summary>
        /// Gets the approver of the release.
        /// </summary>
        [JsonProperty("approver")]
        public ResourceUser Approver { get; set; }

        /// <summary>
        /// Gets the user which approved the release.
        /// </summary>
        [JsonProperty("approvedBy")]
        public ResourceUser ApprovedBy { get; set; }

        /// <summary>
        /// Gets the type of approval.
        /// </summary>
        [JsonProperty("approvalType")]
        public string ApprovalType { get; set; }

        /// <summary>
        /// Gets the created time of the release.
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets the modified time of the release.
        /// </summary>
        [JsonProperty("modifiedOn")]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets the outcome status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets the comments of the approve.
        /// </summary>
        [JsonProperty("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// The IsAutomated.
        /// </summary>
        [JsonProperty("isAutomated")]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// The IsNotificationOn.
        /// </summary>
        [JsonProperty("isNotificationOn")]
        public bool IsNotificationOn { get; set; }

        /// <summary>
        /// Gets the trial number.
        /// </summary>
        [JsonProperty("trialNumber")]
        public int TrialNumber { get; set; }

        /// <summary>
        /// Gets the Attempt.
        /// </summary>
        [JsonProperty("attempt")]
        public int Attempt { get; set; }

        /// <summary>
        /// Gets the Rank.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Gets the Release.
        /// </summary>
        [JsonProperty("release")]
        public Release Release { get; set; }

        /// <summary>
        /// Gets the definition of the release.
        /// </summary>
        [JsonProperty("releaseDefinition")]
        public ReleaseDefinition ReleaseDefinition { get; set; }

        /// <summary>
        /// Gets the environment of the release.
        /// </summary>
        [JsonProperty("releaseEnvironment")]
        public ReleaseEnvironments ReleaseEnvironment { get; set; }
    }
}
