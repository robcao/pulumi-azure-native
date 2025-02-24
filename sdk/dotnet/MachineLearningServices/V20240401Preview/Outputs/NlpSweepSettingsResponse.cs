// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20240401Preview.Outputs
{

    /// <summary>
    /// Model sweeping and hyperparameter tuning related settings.
    /// </summary>
    [OutputType]
    public sealed class NlpSweepSettingsResponse
    {
        /// <summary>
        /// Type of early termination policy for the sweeping job.
        /// </summary>
        public readonly object? EarlyTermination;
        /// <summary>
        /// [Required] Type of sampling algorithm.
        /// </summary>
        public readonly string SamplingAlgorithm;

        [OutputConstructor]
        private NlpSweepSettingsResponse(
            object? earlyTermination,

            string samplingAlgorithm)
        {
            EarlyTermination = earlyTermination;
            SamplingAlgorithm = samplingAlgorithm;
        }
    }
}
