// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes workflow task.
    /// </summary>
    public class ReleaseEnvironmentsWorkflowTask
    {
        /// <summary>
        /// Gets the task identifier.
        /// </summary>
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets the task version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the task name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the AlwaysRun.
        /// </summary>
        [JsonProperty("alwaysRun")]
        public bool AlwaysRun { get; set; }

        /// <summary>
        /// Gets the ContinueOnError.
        /// </summary>
        [JsonProperty("continueOnError")]
        public bool ContinueOnError { get; set; }

        /// <summary>
        /// Gets the TimeoutInMinutes.
        /// </summary>
        [JsonProperty("timeoutInMinutes")]
        public int TimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets the Inputs.
        /// </summary>
        [JsonProperty("inputs")]
        public ReleaseEnvironmentsWorkflowTaskInputs Inputs { get; set; }
    }
}
