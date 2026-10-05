using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxBoxServerAuthentication")]
    public class ZeroTrustCasbIntegrationBoxBoxServerAuthentication : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBoxBoxServerAuthentication
    {
        /// <summary>Box Enterprise ID from Admin Console &gt; Accounts &amp; Billing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#enterprise_id ZeroTrustCasbIntegration#enterprise_id}
        /// </remarks>
        [JsiiProperty(name: "enterpriseId", typeJson: "{\"primitive\":\"string\"}")]
        public string EnterpriseId
        {
            get;
            set;
        }
    }
}
