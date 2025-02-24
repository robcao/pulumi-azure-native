// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class EtwProviderConfigurationResponse
    {
        public readonly ImmutableArray<Outputs.EtwEventConfigurationResponse> Events;
        public readonly string Id;

        [OutputConstructor]
        private EtwProviderConfigurationResponse(
            ImmutableArray<Outputs.EtwEventConfigurationResponse> events,

            string id)
        {
            Events = events;
            Id = id;
        }
    }
}
