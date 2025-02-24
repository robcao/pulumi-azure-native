// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureStackHCI.V20221215Preview.Inputs
{

    public sealed class IPPoolArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// end of the ip address pool
        /// </summary>
        [Input("end")]
        public Input<string>? End { get; set; }

        /// <summary>
        /// ip pool type
        /// </summary>
        [Input("ipPoolType")]
        public Input<Pulumi.AzureNative.AzureStackHCI.V20221215Preview.IPPoolTypeEnum>? IpPoolType { get; set; }

        /// <summary>
        /// start of the ip address pool
        /// </summary>
        [Input("start")]
        public Input<string>? Start { get; set; }

        public IPPoolArgs()
        {
        }
        public static new IPPoolArgs Empty => new IPPoolArgs();
    }
}
