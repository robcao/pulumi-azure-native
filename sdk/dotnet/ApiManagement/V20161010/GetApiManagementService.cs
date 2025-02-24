// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20161010
{
    public static class GetApiManagementService
    {
        /// <summary>
        /// Gets an API Management service resource description.
        /// </summary>
        public static Task<GetApiManagementServiceResult> InvokeAsync(GetApiManagementServiceArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiManagementServiceResult>("azure-native:apimanagement/v20161010:getApiManagementService", args ?? new GetApiManagementServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Gets an API Management service resource description.
        /// </summary>
        public static Output<GetApiManagementServiceResult> Invoke(GetApiManagementServiceInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiManagementServiceResult>("azure-native:apimanagement/v20161010:getApiManagementService", args ?? new GetApiManagementServiceInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Gets an API Management service resource description.
        /// </summary>
        public static Output<GetApiManagementServiceResult> Invoke(GetApiManagementServiceInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiManagementServiceResult>("azure-native:apimanagement/v20161010:getApiManagementService", args ?? new GetApiManagementServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiManagementServiceArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetApiManagementServiceArgs()
        {
        }
        public static new GetApiManagementServiceArgs Empty => new GetApiManagementServiceArgs();
    }

    public sealed class GetApiManagementServiceInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public GetApiManagementServiceInvokeArgs()
        {
        }
        public static new GetApiManagementServiceInvokeArgs Empty => new GetApiManagementServiceInvokeArgs();
    }


    [OutputType]
    public sealed class GetApiManagementServiceResult
    {
        /// <summary>
        /// Additional datacenter locations of the API Management service.
        /// </summary>
        public readonly ImmutableArray<Outputs.AdditionalRegionResponse> AdditionalLocations;
        /// <summary>
        /// Addresser email.
        /// </summary>
        public readonly string? AddresserEmail;
        /// <summary>
        /// Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        public readonly string CreatedAtUtc;
        /// <summary>
        /// Custom properties of the API Management service, like disabling TLS 1.0.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? CustomProperties;
        /// <summary>
        /// ETag of the resource.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Custom hostname configuration of the API Management service.
        /// </summary>
        public readonly ImmutableArray<Outputs.HostnameConfigurationResponse> HostnameConfigurations;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Management API endpoint URL of the API Management service.
        /// </summary>
        public readonly string ManagementApiUrl;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Publisher portal endpoint Url of the API Management service.
        /// </summary>
        public readonly string PortalUrl;
        /// <summary>
        /// The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Publisher email.
        /// </summary>
        public readonly string PublisherEmail;
        /// <summary>
        /// Publisher name.
        /// </summary>
        public readonly string PublisherName;
        /// <summary>
        /// Proxy endpoint URL of the API Management service.
        /// </summary>
        public readonly string RuntimeUrl;
        /// <summary>
        /// SCM endpoint URL of the API Management service.
        /// </summary>
        public readonly string ScmUrl;
        /// <summary>
        /// SKU properties of the API Management service.
        /// </summary>
        public readonly Outputs.ApiManagementServiceSkuPropertiesResponse Sku;
        /// <summary>
        /// Static IP addresses of the API Management service virtual machines. Available only for Standard and Premium SKU.
        /// </summary>
        public readonly ImmutableArray<string> StaticIPs;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The provisioning state of the API Management service, which is targeted by the long running operation started on the service.
        /// </summary>
        public readonly string TargetProvisioningState;
        /// <summary>
        /// Resource type for API Management resource is set to Microsoft.ApiManagement.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
        /// </summary>
        public readonly string? VpnType;
        /// <summary>
        /// Virtual network configuration of the API Management service.
        /// </summary>
        public readonly Outputs.VirtualNetworkConfigurationResponse? Vpnconfiguration;

        [OutputConstructor]
        private GetApiManagementServiceResult(
            ImmutableArray<Outputs.AdditionalRegionResponse> additionalLocations,

            string? addresserEmail,

            string createdAtUtc,

            ImmutableDictionary<string, string>? customProperties,

            string etag,

            ImmutableArray<Outputs.HostnameConfigurationResponse> hostnameConfigurations,

            string id,

            string location,

            string managementApiUrl,

            string? name,

            string portalUrl,

            string provisioningState,

            string publisherEmail,

            string publisherName,

            string runtimeUrl,

            string scmUrl,

            Outputs.ApiManagementServiceSkuPropertiesResponse sku,

            ImmutableArray<string> staticIPs,

            ImmutableDictionary<string, string>? tags,

            string targetProvisioningState,

            string type,

            string? vpnType,

            Outputs.VirtualNetworkConfigurationResponse? vpnconfiguration)
        {
            AdditionalLocations = additionalLocations;
            AddresserEmail = addresserEmail;
            CreatedAtUtc = createdAtUtc;
            CustomProperties = customProperties;
            Etag = etag;
            HostnameConfigurations = hostnameConfigurations;
            Id = id;
            Location = location;
            ManagementApiUrl = managementApiUrl;
            Name = name;
            PortalUrl = portalUrl;
            ProvisioningState = provisioningState;
            PublisherEmail = publisherEmail;
            PublisherName = publisherName;
            RuntimeUrl = runtimeUrl;
            ScmUrl = scmUrl;
            Sku = sku;
            StaticIPs = staticIPs;
            Tags = tags;
            TargetProvisioningState = targetProvisioningState;
            Type = type;
            VpnType = vpnType;
            Vpnconfiguration = vpnconfiguration;
        }
    }
}
