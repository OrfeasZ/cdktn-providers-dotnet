using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp")]
    public interface IZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp
    {
        /// <summary>The UID of the IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#idp_id ZeroTrustAccessApplication#idp_id}
        /// </remarks>
        [JsiiProperty(name: "idpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdpId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the IdP provided attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#source_name ZeroTrustAccessApplication#source_name}
        /// </remarks>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributesSourceNameByIdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The UID of the IdP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#idp_id ZeroTrustAccessApplication#idp_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdpId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the IdP provided attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#source_name ZeroTrustAccessApplication#source_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
