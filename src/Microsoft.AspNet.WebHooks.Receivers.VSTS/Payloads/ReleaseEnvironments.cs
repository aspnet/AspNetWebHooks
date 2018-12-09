// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes environments of release.
    /// </summary>
    public class ReleaseEnvironments
    {
        private readonly Collection<object> _preApprovalsSnapshot = new Collection<object>();
        private readonly Collection<object> _postApprovalsSnapshot = new Collection<object>();
        private readonly Collection<object> _deploySteps = new Collection<object>();
        private readonly Collection<object> _demands = new Collection<object>();
        private readonly Collection<object> _conditions = new Collection<object>();
        private readonly Collection<ReleaseEnvironmentsWorkflowTask> _workflowTasks = new Collection<ReleaseEnvironmentsWorkflowTask>();
        private readonly Collection<object> _deployPhasesSnapshot = new Collection<object>();
        private readonly Collection<object> _schedules = new Collection<object>();

        /// <summary>
        /// Gets the environment identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the release identifier.
        /// </summary>
        [JsonProperty("releaseId")]
        public int ReleaseId { get; set; }

        /// <summary>
        /// Gets the environment name.
        /// </summary>
        [JsonProperty("name")]
        public int Name { get; set; }

        /// <summary>
        /// Gets the outcome status of the environment.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets variables of the environment.
        /// </summary>
        [JsonProperty("variables")]
        public ReleaseEnvironmentsVariables Variables { get; set; }

        /// <summary>
        /// Gets PreDeploy approvals.
        /// </summary>
        [JsonProperty("preDeployApprovals")]
        public Collection<object> PreDeployApprovals
        {
            get { return _preApprovalsSnapshot; }
        }

        /// <summary>
        /// Gets PostDeploy approvals.
        /// </summary>
        [JsonProperty("postDeployApprovals")]
        public Collection<object> PostDeployApprovals
        {
            get { return _postApprovalsSnapshot; }
        }

        /// <summary>
        /// Gets the pre approvals snapshot.
        /// </summary>
        [JsonProperty("preApprovalsSnapshot")]
        public ReleaseEnvironmentsPreApprovalsSnapshot PreApprovalsSnapshot { get; set; }

        /// <summary>
        /// Gets the post approvals snapshot.
        /// </summary>
        [JsonProperty("postApprovalsSnapshot")]
        public ReleaseEnvironmentsPostApprovalsSnapshot PostApprovalsSnapshot { get; set; }

        /// <summary>
        /// Gets steps of deploy.
        /// </summary>
        [JsonProperty("deploySteps")]
        public Collection<object> DeploySteps
        {
            get { return _deploySteps; }
        }

        /// <summary>
        /// Gets the rank.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Gets the definition environment identifier.
        /// </summary>
        [JsonProperty("definitionEnvironmentId")]
        public int DefinitionEnvironmentId { get; set; }

        /// <summary>
        /// Gets the queue identifier.
        /// </summary>
        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        /// <summary>
        /// Gets environment options.
        /// </summary>
        [JsonProperty("environmentOptions")]
        public ReleaseEnvironmentsEnvironmentOptions EnvironmentOptions { get; set; }

        /// <summary>
        /// Gets demands.
        /// </summary>
        [JsonProperty("demands")]
        public Collection<object> Demands
        {
            get { return _demands; }
        }

        /// <summary>
        /// Gets conditions.
        /// </summary>
        [JsonProperty("conditions")]
        public Collection<object> Conditions
        {
            get { return _conditions; }
        }

        /// <summary>
        /// Gets the modified time of the release.
        /// </summary>
        [JsonProperty("modifiedOn")]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets workflow tasks.
        /// </summary>
        [JsonProperty("workflowTasks")]
        public Collection<ReleaseEnvironmentsWorkflowTask> WorkflowTasks
        {
            get { return _workflowTasks; }
        }

        /// <summary>
        /// Gets deploy phases snapshot.
        /// </summary>
        [JsonProperty("deployPhasesSnapshot")]
        public Collection<object> DeployPhasesSnapshot
        {
            get { return _deployPhasesSnapshot; }
        }

        /// <summary>
        /// Gets the user which is the owner.
        /// </summary>
        [JsonProperty("owner")]
        public ResourceUser Owner { get; set; }

        /// <summary>
        /// Gets the scheduled deployment time of the release.
        /// </summary>
        [JsonProperty("scheduledDeploymentTime")]
        public DateTime ScheduledDeploymentTime { get; set; }

        /// <summary>
        /// Gets schedules.
        /// </summary>
        [JsonProperty("schedules")]
        public Collection<object> Schedules
        {
            get { return _schedules; }
        }

        /// <summary>
        /// Gets current release.
        /// </summary>
        [JsonProperty("release")]
        public ReleaseEnvironmentsRelease Release { get; set; }
    }
}
