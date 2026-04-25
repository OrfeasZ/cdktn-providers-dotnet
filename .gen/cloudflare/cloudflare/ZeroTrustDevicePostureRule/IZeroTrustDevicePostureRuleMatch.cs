using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureRule
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDevicePostureRuleMatch), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleMatch")]
    public interface IZeroTrustDevicePostureRuleMatch
    {
        /// <summary>Available values: "windows", "mac", "linux", "android", "ios", "chromeos".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#platform ZeroTrustDevicePostureRule#platform}
        /// </remarks>
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Platform
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDevicePostureRuleMatch), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleMatch")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "windows", "mac", "linux", "android", "ios", "chromeos".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#platform ZeroTrustDevicePostureRule#platform}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Platform
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
