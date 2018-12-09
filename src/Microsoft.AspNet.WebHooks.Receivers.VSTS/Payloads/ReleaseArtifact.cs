// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the artifact of the release.
    /// </summary>
    public class ReleaseArtifact
    {
        /// <summary>
        /// Gets the source identifier.
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets the artifact type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the artifact alias.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Gets the artifact definition reference.
        /// </summary>
        [JsonProperty("definitionReference")]
        public ReleaseArtifactDefinitionReference DefinitionReference { get; set; }

        /// <summary>
        /// Gets the IsPrimary.
        /// </summary>
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }
}
