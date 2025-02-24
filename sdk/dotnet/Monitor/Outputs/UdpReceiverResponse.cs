// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Monitor.Outputs
{

    /// <summary>
    /// Receiver using UDP as transport protocol.
    /// </summary>
    [OutputType]
    public sealed class UdpReceiverResponse
    {
        /// <summary>
        /// The encoding of the stream being received.
        /// </summary>
        public readonly string? Encoding;
        /// <summary>
        /// TCP endpoint definition. Example: 0.0.0.0:&lt;port&gt;.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// Max read queue length.
        /// </summary>
        public readonly int? ReadQueueLength;

        [OutputConstructor]
        private UdpReceiverResponse(
            string? encoding,

            string endpoint,

            int? readQueueLength)
        {
            Encoding = encoding;
            Endpoint = endpoint;
            ReadQueueLength = readQueueLength;
        }
    }
}
