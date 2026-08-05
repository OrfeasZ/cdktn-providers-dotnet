using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderClaimMapping), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderClaimMapping")]
    public interface IIdentityDomainsIdentityProofingProviderClaimMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/identity_domains_identity_proofing_provider#attr_match IdentityDomainsIdentityProofingProvider#attr_match}.</summary>
        [JsiiProperty(name: "attrMatch", typeJson: "{\"primitive\":\"string\"}")]
        string AttrMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/identity_domains_identity_proofing_provider#verifiable_claim IdentityDomainsIdentityProofingProvider#verifiable_claim}.</summary>
        [JsiiProperty(name: "verifiableClaim", typeJson: "{\"primitive\":\"string\"}")]
        string VerifiableClaim
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderClaimMapping), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderClaimMapping")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderClaimMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/identity_domains_identity_proofing_provider#attr_match IdentityDomainsIdentityProofingProvider#attr_match}.</summary>
            [JsiiProperty(name: "attrMatch", typeJson: "{\"primitive\":\"string\"}")]
            public string AttrMatch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/identity_domains_identity_proofing_provider#verifiable_claim IdentityDomainsIdentityProofingProvider#verifiable_claim}.</summary>
            [JsiiProperty(name: "verifiableClaim", typeJson: "{\"primitive\":\"string\"}")]
            public string VerifiableClaim
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
