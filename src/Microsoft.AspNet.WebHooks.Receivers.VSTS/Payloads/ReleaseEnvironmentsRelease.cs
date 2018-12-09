// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Newtonsoft.Json;

namespace Microsoft.AspNet.WebHooks.Payloads
{
    /// <summary>
    /// Describes the release in scope of environment.
    /// </summary>
    public class ReleaseEnvironmentsRelease
    {
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
        /// Gets the release URL.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
