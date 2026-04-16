using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp")]
    public class ZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp
    {
        /// <summary>The UID of the IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#idp_id ZeroTrustAccessApplication#idp_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdpId
        {
            get;
            set;
        }

        /// <summary>The name of the IdP provided attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#source_name ZeroTrustAccessApplication#source_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceName
        {
            get;
            set;
        }
    }
}
