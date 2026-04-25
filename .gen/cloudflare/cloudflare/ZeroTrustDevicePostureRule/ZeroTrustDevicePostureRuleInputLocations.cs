using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureRule
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInputLocations")]
    public class ZeroTrustDevicePostureRuleInputLocations : cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInputLocations
    {
        /// <summary>List of paths to check for client certificate on linux.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#paths ZeroTrustDevicePostureRule#paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Paths
        {
            get;
            set;
        }

        /// <summary>List of trust stores to check for client certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_rule#trust_stores ZeroTrustDevicePostureRule#trust_stores}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustStores", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustStores
        {
            get;
            set;
        }
    }
}
