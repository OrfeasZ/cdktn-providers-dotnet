using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePosture")]
    public class ZeroTrustAccessGroupExcludeDevicePosture : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture
    {
        /// <summary>The ID of a device posture integration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#integration_uid ZeroTrustAccessGroup#integration_uid}
        /// </remarks>
        [JsiiProperty(name: "integrationUid", typeJson: "{\"primitive\":\"string\"}")]
        public string IntegrationUid
        {
            get;
            set;
        }
    }
}
