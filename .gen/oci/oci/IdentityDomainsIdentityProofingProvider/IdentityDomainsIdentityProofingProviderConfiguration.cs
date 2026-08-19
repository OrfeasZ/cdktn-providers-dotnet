using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfiguration")]
    public class IdentityDomainsIdentityProofingProviderConfiguration : oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#name IdentityDomainsIdentityProofingProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#value IdentityDomainsIdentityProofingProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
