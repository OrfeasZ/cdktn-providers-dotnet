using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessIdentityProvider
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderFilter")]
    public class DataCloudflareZeroTrustAccessIdentityProviderFilter : cloudflare.DataCloudflareZeroTrustAccessIdentityProvider.IDataCloudflareZeroTrustAccessIdentityProviderFilter
    {
        /// <summary>Indicates to Access to only retrieve identity providers that have the System for Cross-Domain Identity Management (SCIM) enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_identity_provider#scim_enabled DataCloudflareZeroTrustAccessIdentityProvider#scim_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scimEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScimEnabled
        {
            get;
            set;
        }
    }
}
