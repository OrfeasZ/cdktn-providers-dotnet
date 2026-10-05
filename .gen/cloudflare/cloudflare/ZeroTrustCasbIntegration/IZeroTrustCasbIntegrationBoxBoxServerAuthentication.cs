using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationBoxBoxServerAuthentication), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxBoxServerAuthentication")]
    public interface IZeroTrustCasbIntegrationBoxBoxServerAuthentication
    {
        /// <summary>Box Enterprise ID from Admin Console &gt; Accounts &amp; Billing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#enterprise_id ZeroTrustCasbIntegration#enterprise_id}
        /// </remarks>
        [JsiiProperty(name: "enterpriseId", typeJson: "{\"primitive\":\"string\"}")]
        string EnterpriseId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationBoxBoxServerAuthentication), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxBoxServerAuthentication")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBoxBoxServerAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Box Enterprise ID from Admin Console &gt; Accounts &amp; Billing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#enterprise_id ZeroTrustCasbIntegration#enterprise_id}
            /// </remarks>
            [JsiiProperty(name: "enterpriseId", typeJson: "{\"primitive\":\"string\"}")]
            public string EnterpriseId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
