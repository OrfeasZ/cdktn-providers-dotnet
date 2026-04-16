using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureRule
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleMatch")]
    public class ZeroTrustDevicePostureRuleMatch : cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleMatch
    {
        /// <summary>Available values: "windows", "mac", "linux", "android", "ios", "chromeos".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#platform ZeroTrustDevicePostureRule#platform}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Platform
        {
            get;
            set;
        }
    }
}
