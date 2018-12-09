// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the artifact definition reference.
    /// </summary>
    public class ReleaseArtifactDefinitionReference
    {
        /// <summary>
        /// Gets the Definition.
        /// </summary>
        [JsonProperty("Definition")]
        public ReleaseArtifactDefinitionReferenceInfo Definition { get; set; }

        /// <summary>
        /// Gets the Project.
        /// </summary>
        [JsonProperty("Project")]
        public ReleaseArtifactDefinitionReferenceInfo Project { get; set; }
    }
}
