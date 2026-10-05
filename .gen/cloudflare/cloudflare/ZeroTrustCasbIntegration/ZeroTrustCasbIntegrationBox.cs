using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBox")]
    public class ZeroTrustCasbIntegrationBox : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBox
    {
        /// <summary>Authenticate with Box server authentication.</summary>
        /// <remarks>
        /// Before creating the integration, add the Cloudflare CASB application in Box Admin Console &gt; Integrations &gt; Platform Apps Manager &gt; Server Authentication Apps using client ID <c>puaghckpy0578r8p6f3g0rf860unup4r</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#box_server_authentication ZeroTrustCasbIntegration#box_server_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boxServerAuthentication", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxBoxServerAuthentication\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBoxBoxServerAuthentication? BoxServerAuthentication
        {
            get;
            set;
        }
    }
}
