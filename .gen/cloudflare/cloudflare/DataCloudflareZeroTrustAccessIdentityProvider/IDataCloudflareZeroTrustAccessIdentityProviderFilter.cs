using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessIdentityProviderFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderFilter")]
    public interface IDataCloudflareZeroTrustAccessIdentityProviderFilter
    {
        /// <summary>Indicates to Access to only retrieve identity providers that have the System for Cross-Domain Identity Management (SCIM) enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_identity_provider#scim_enabled DataCloudflareZeroTrustAccessIdentityProvider#scim_enabled}
        /// </remarks>
        [JsiiProperty(name: "scimEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScimEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessIdentityProviderFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessIdentityProvider.IDataCloudflareZeroTrustAccessIdentityProviderFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates to Access to only retrieve identity providers that have the System for Cross-Domain Identity Management (SCIM) enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_identity_provider#scim_enabled DataCloudflareZeroTrustAccessIdentityProvider#scim_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scimEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScimEnabled
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
