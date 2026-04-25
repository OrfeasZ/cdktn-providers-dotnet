using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureRule
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDevicePostureRuleInputLocations), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInputLocations")]
    public interface IZeroTrustDevicePostureRuleInputLocations
    {
        /// <summary>List of paths to check for client certificate on linux.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#paths ZeroTrustDevicePostureRule#paths}
        /// </remarks>
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Paths
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of trust stores to check for client certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#trust_stores ZeroTrustDevicePostureRule#trust_stores}
        /// </remarks>
        [JsiiProperty(name: "trustStores", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustStores
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDevicePostureRuleInputLocations), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInputLocations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInputLocations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of paths to check for client certificate on linux.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#paths ZeroTrustDevicePostureRule#paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Paths
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of trust stores to check for client certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#trust_stores ZeroTrustDevicePostureRule#trust_stores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustStores", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustStores
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
