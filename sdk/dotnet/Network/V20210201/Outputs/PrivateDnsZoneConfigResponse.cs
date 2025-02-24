// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201.Outputs
{

    /// <summary>
    /// PrivateDnsZoneConfig resource.
    /// </summary>
    [OutputType]
    public sealed class PrivateDnsZoneConfigResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The id of the privateDnsZoneConfig.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The resource id of the private dns zone.
        /// </summary>
        public readonly string? PrivateDnsZoneId;
        /// <summary>
        /// The provisioning state of the private dns zone group resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// A collection of information regarding a recordSet, holding information to identify private resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.RecordSetResponse> RecordSets;
        /// <summary>
        /// Type of resource. Will be specified as private dns zone configurations.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrivateDnsZoneConfigResponse(
            string etag,

            string id,

            string? name,

            string? privateDnsZoneId,

            string provisioningState,

            ImmutableArray<Outputs.RecordSetResponse> recordSets,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            PrivateDnsZoneId = privateDnsZoneId;
            ProvisioningState = provisioningState;
            RecordSets = recordSets;
            Type = type;
        }
    }
}
