using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderClaimMapping")]
    public class IdentityDomainsIdentityProofingProviderClaimMapping : oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderClaimMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_proofing_provider#attr_match IdentityDomainsIdentityProofingProvider#attr_match}.</summary>
        [JsiiProperty(name: "attrMatch", typeJson: "{\"primitive\":\"string\"}")]
        public string AttrMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_proofing_provider#verifiable_claim IdentityDomainsIdentityProofingProvider#verifiable_claim}.</summary>
        [JsiiProperty(name: "verifiableClaim", typeJson: "{\"primitive\":\"string\"}")]
        public string VerifiableClaim
        {
            get;
            set;
        }
    }
}
