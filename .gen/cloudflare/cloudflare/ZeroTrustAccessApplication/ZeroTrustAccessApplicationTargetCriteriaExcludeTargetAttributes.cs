using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaExcludeTargetAttributes")]
    public class ZeroTrustAccessApplicationTargetCriteriaExcludeTargetAttributes : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaExcludeTargetAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#hostname ZeroTrustAccessApplication#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Hostname
        {
            get;
            set;
        }
    }
}
