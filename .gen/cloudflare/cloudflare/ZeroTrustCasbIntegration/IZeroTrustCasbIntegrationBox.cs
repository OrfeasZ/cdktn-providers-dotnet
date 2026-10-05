using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationBox), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBox")]
    public interface IZeroTrustCasbIntegrationBox
    {
        /// <summary>Authenticate with Box server authentication.</summary>
        /// <remarks>
        /// Before creating the integration, add the Cloudflare CASB application in Box Admin Console &gt; Integrations &gt; Platform Apps Manager &gt; Server Authentication Apps using client ID <c>puaghckpy0578r8p6f3g0rf860unup4r</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#box_server_authentication ZeroTrustCasbIntegration#box_server_authentication}
        /// </remarks>
        [JsiiProperty(name: "boxServerAuthentication", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxBoxServerAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBoxBoxServerAuthentication? BoxServerAuthentication
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationBox), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBox")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBox
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBoxBoxServerAuthentication?>();
            }
        }
    }
}
