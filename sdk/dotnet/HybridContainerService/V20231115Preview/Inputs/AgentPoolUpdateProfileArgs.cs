// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridContainerService.V20231115Preview.Inputs
{

    /// <summary>
    /// AgentPool update configuration
    /// </summary>
    public sealed class AgentPoolUpdateProfileArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// VmSize - The size of the agent pool VMs.
        /// </summary>
        [Input("vmSize")]
        public Input<string>? VmSize { get; set; }

        public AgentPoolUpdateProfileArgs()
        {
            Count = 1;
        }
        public static new AgentPoolUpdateProfileArgs Empty => new AgentPoolUpdateProfileArgs();
    }
}
