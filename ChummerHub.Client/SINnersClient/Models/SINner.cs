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

    public partial class SINner
    {
        /// <summary>
        /// Initializes a new instance of the SINner class.
        /// </summary>
        public SINner() { }

        /// <summary>
        /// Initializes a new instance of the SINner class.
        /// </summary>
        public SINner(Guid? id = default(Guid?), string downloadUrl = default(string), DateTime? uploadDateTime = default(DateTime?), DateTime? lastChange = default(DateTime?), SINnerMetaData siNnerMetaData = default(SINnerMetaData), string jsonSummary = default(string))
        {
            Id = id;
            DownloadUrl = downloadUrl;
            UploadDateTime = uploadDateTime;
            LastChange = lastChange;
            SiNnerMetaData = siNnerMetaData;
            JsonSummary = jsonSummary;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uploadDateTime")]
        public DateTime? UploadDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastChange")]
        public DateTime? LastChange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siNnerMetaData")]
        public SINnerMetaData SiNnerMetaData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jsonSummary")]
        public string JsonSummary { get; set; }

    }
}
