// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.VoiceServices.V20221201Preview
{
    /// <summary>
    /// Purpose of this test line, e.g. automated or manual testing
    /// </summary>
    [EnumType]
    public readonly struct TestLinePurpose : IEquatable<TestLinePurpose>
    {
        private readonly string _value;

        private TestLinePurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static TestLinePurpose Manual { get; } = new TestLinePurpose("Manual");
        public static TestLinePurpose Automated { get; } = new TestLinePurpose("Automated");

        public static bool operator ==(TestLinePurpose left, TestLinePurpose right) => left.Equals(right);
        public static bool operator !=(TestLinePurpose left, TestLinePurpose right) => !left.Equals(right);

        public static explicit operator string(TestLinePurpose value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TestLinePurpose other && Equals(other);
        public bool Equals(TestLinePurpose other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
