// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Quota.V20241015Preview.Outputs
{

    /// <summary>
    /// Properties and filters for ShareQuota. The request parameter is optional, if there are no filters specified.
    /// </summary>
    [OutputType]
    public sealed class GroupQuotasEntityBaseResponse
    {
        /// <summary>
        /// Additional attributes to filter/restrict the subscriptions, which can be added to the subscriptionIds.
        /// </summary>
        public readonly Outputs.AdditionalAttributesResponse? AdditionalAttributes;
        /// <summary>
        /// Display name of the GroupQuota entity.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Provisioning state of the operation.
        /// </summary>
        public readonly string ProvisioningState;

        [OutputConstructor]
        private GroupQuotasEntityBaseResponse(
            Outputs.AdditionalAttributesResponse? additionalAttributes,

            string? displayName,

            string provisioningState)
        {
            AdditionalAttributes = additionalAttributes;
            DisplayName = displayName;
            ProvisioningState = provisioningState;
        }
    }
}
