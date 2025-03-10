// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB resource throughput object. Either throughput is required or
    /// autoscaleSettings is required, but not both.
    /// </summary>
    public partial class ThroughputSettingsResource
    {
        /// <summary>
        /// Initializes a new instance of the ThroughputSettingsResource class.
        /// </summary>
        public ThroughputSettingsResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThroughputSettingsResource class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput. Either throughput is required or autoscaleSettings is
        /// required, but not both.</param>
        /// <param name="autoscaleSettings">Cosmos DB resource for autoscale
        /// settings. Either throughput is required or autoscaleSettings is
        /// required, but not both.</param>
        /// <param name="minimumThroughput">The minimum throughput of the
        /// resource</param>
        /// <param name="offerReplacePending">The throughput replace is
        /// pending</param>
        /// <param name="instantMaximumThroughput">The offer throughput value
        /// to instantly scale up without triggering splits</param>
        /// <param name="softAllowedMaximumThroughput">The maximum throughput
        /// value or the maximum maxThroughput value (for autoscale) that can
        /// be specified</param>
        public ThroughputSettingsResource(int? throughput = default(int?), AutoscaleSettingsResource autoscaleSettings = default(AutoscaleSettingsResource), string minimumThroughput = default(string), string offerReplacePending = default(string), string instantMaximumThroughput = default(string), string softAllowedMaximumThroughput = default(string))
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            InstantMaximumThroughput = instantMaximumThroughput;
            SoftAllowedMaximumThroughput = softAllowedMaximumThroughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput. Either
        /// throughput is required or autoscaleSettings is required, but not
        /// both.
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int? Throughput { get; set; }

        /// <summary>
        /// Gets or sets cosmos DB resource for autoscale settings. Either
        /// throughput is required or autoscaleSettings is required, but not
        /// both.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaleSettings")]
        public AutoscaleSettingsResource AutoscaleSettings { get; set; }

        /// <summary>
        /// Gets the minimum throughput of the resource
        /// </summary>
        [JsonProperty(PropertyName = "minimumThroughput")]
        public string MinimumThroughput { get; private set; }

        /// <summary>
        /// Gets the throughput replace is pending
        /// </summary>
        [JsonProperty(PropertyName = "offerReplacePending")]
        public string OfferReplacePending { get; private set; }

        /// <summary>
        /// Gets the offer throughput value to instantly scale up without
        /// triggering splits
        /// </summary>
        [JsonProperty(PropertyName = "instantMaximumThroughput")]
        public string InstantMaximumThroughput { get; private set; }

        /// <summary>
        /// Gets the maximum throughput value or the maximum maxThroughput
        /// value (for autoscale) that can be specified
        /// </summary>
        [JsonProperty(PropertyName = "softAllowedMaximumThroughput")]
        public string SoftAllowedMaximumThroughput { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AutoscaleSettings != null)
            {
                AutoscaleSettings.Validate();
            }
        }
    }
}
