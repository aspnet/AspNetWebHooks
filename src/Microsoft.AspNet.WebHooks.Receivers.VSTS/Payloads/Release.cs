// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes release.
    /// </summary>
    public class Release
    {
        private readonly Collection<ReleaseEnvironments> _environments = new Collection<ReleaseEnvironments>();
        private readonly Collection<ReleaseArtifact> _artifacts = new Collection<ReleaseArtifact>();

        /// <summary>
        /// Gets the release identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the release name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the outcome status of the release.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

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
        /// Gets the user which last changed the release.
        /// </summary>
        [JsonProperty("modifiedBy")]
        public ResourceUser ModifiedBy { get; set; }

        /// <summary>
        /// Gets the user which created the release.
        /// </summary>
        [JsonProperty("createdBy")]
        public ResourceUser CreatedBy { get; set; }

        /// <summary>
        /// Gets the environments of the release.
        /// </summary>
        [JsonProperty("environments")]
        public Collection<ReleaseEnvironments> Environments
        {
            get { return _environments; }
        }

        /// <summary>
        /// Gets variables of the release.
        /// </summary>
        [JsonProperty("variables")]
        public ReleaseVariables Variables { get; set; }

        /// <summary>
        /// Gets artifacts of the release.
        /// </summary>
        [JsonProperty("artifacts")]
        public Collection<ReleaseArtifact> Artifacts
        {
            get { return _artifacts; }
        }

        /// <summary>
        /// Gets the definition of the release.
        /// </summary>
        [JsonProperty("releaseDefinition")]
        public ReleaseDefinition ReleaseDefinition { get; set; }

        /// <summary>
        /// Gets the description of the release.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the reason of the release.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets the name format of the release.
        /// </summary>
        [JsonProperty("releaseNameFormat")]
        public string ReleaseNameFormat { get; set; }

        /// <summary>
        /// Is KeepForever.
        /// </summary>
        [JsonProperty("keepForever")]
        public bool KeepForever { get; set; }

        /// <summary>
        /// Gets the definition snapshot revision of the release.
        /// </summary>
        [JsonProperty("definitionSnapshotRevision")]
        public int DefinitionSnapshotRevision { get; set; }

        /// <summary>
        /// Gets the comment of the release.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets links of the release.
        /// </summary>
        [JsonProperty("_links")]
        public ReleaseLinks Links { get; set; }
    }
}
