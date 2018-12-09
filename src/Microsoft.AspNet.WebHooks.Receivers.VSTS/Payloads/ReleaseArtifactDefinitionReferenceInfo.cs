// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the artifact definition reference.
    /// </summary>
    public class ReleaseArtifactDefinitionReferenceInfo
    {
        /// <summary>
        /// Gets the Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets the Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
