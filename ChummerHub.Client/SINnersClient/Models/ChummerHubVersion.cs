﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SINners.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ChummerHubVersion
    {
        /// <summary>
        /// Initializes a new instance of the ChummerHubVersion class.
        /// </summary>
        public ChummerHubVersion() { }

        /// <summary>
        /// Initializes a new instance of the ChummerHubVersion class.
        /// </summary>
        public ChummerHubVersion(string assemblyVersion = default(string))
        {
            AssemblyVersion = assemblyVersion;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assemblyVersion")]
        public string AssemblyVersion { get; set; }

    }
}
