// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridConnectivity.Inputs
{

    /// <summary>
    /// Endpoint details
    /// </summary>
    public sealed class EndpointPropertiesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource Id of the connectivity endpoint (optional).
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        /// <summary>
        /// The type of endpoint.
        /// </summary>
        [Input("type", required: true)]
        public InputUnion<string, Pulumi.AzureNative.HybridConnectivity.Type> Type { get; set; } = null!;

        public EndpointPropertiesArgs()
        {
        }
        public static new EndpointPropertiesArgs Empty => new EndpointPropertiesArgs();
    }
}
