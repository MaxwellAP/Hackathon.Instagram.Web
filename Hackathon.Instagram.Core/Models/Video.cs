﻿using Newtonsoft.Json;

namespace Hackathon.Instagram.Core.Models
{
    public class Video
    {

        /// <summary>
        /// Gets or sets the low resolution.
        /// </summary>
        /// <value>
        /// The low resolution.
        /// </value>
        [JsonProperty("low_resolution")]
        public Resolution LowResolution { get; set; }

        /// <summary>
        /// Gets or sets the standard resolution.
        /// </summary>
        /// <value>
        /// The standard resolution.
        /// </value>
        [JsonProperty("standard_resolution")]
        public Resolution StandardResolution { get; set; }
    }
}