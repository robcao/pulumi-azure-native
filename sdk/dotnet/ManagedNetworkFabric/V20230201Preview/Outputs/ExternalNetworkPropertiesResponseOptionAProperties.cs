// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ManagedNetworkFabric.V20230201Preview.Outputs
{

    /// <summary>
    /// option A properties object
    /// </summary>
    [OutputType]
    public sealed class ExternalNetworkPropertiesResponseOptionAProperties
    {
        /// <summary>
        /// BFD configuration properties
        /// </summary>
        public readonly Outputs.BfdConfigurationResponse? BfdConfiguration;
        /// <summary>
        /// Fabric ASN number. Example 65001 
        /// </summary>
        public readonly int FabricASN;
        /// <summary>
        /// MTU to use for option A peering.
        /// </summary>
        public readonly int? Mtu;
        /// <summary>
        /// Peer ASN number.Example : 28
        /// </summary>
        public readonly int PeerASN;
        /// <summary>
        /// IPv4 Address Prefix of CE-PE interconnect links. Example: 172.31.0.0/31. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces.
        /// </summary>
        public readonly string? PrimaryIpv4Prefix;
        /// <summary>
        /// IPv6 Address Prefix of CE-PE interconnect links. Example: 3FFE:FFFF:0:CD30::a0/126. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces.
        /// </summary>
        public readonly string? PrimaryIpv6Prefix;
        /// <summary>
        /// Secondary IPv4 Address Prefix of CE-PE interconnect links. Example: 172.31.0.20/31. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces.
        /// </summary>
        public readonly string? SecondaryIpv4Prefix;
        /// <summary>
        /// Secondary IPv6 Address Prefix of CE-PE interconnect links. Example: 3FFE:FFFF:0:CD30::a4/126. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces.
        /// </summary>
        public readonly string? SecondaryIpv6Prefix;
        /// <summary>
        /// Vlan identifier. Example : 501
        /// </summary>
        public readonly int VlanId;

        [OutputConstructor]
        private ExternalNetworkPropertiesResponseOptionAProperties(
            Outputs.BfdConfigurationResponse? bfdConfiguration,

            int fabricASN,

            int? mtu,

            int peerASN,

            string? primaryIpv4Prefix,

            string? primaryIpv6Prefix,

            string? secondaryIpv4Prefix,

            string? secondaryIpv6Prefix,

            int vlanId)
        {
            BfdConfiguration = bfdConfiguration;
            FabricASN = fabricASN;
            Mtu = mtu;
            PeerASN = peerASN;
            PrimaryIpv4Prefix = primaryIpv4Prefix;
            PrimaryIpv6Prefix = primaryIpv6Prefix;
            SecondaryIpv4Prefix = secondaryIpv4Prefix;
            SecondaryIpv6Prefix = secondaryIpv6Prefix;
            VlanId = vlanId;
        }
    }
}
