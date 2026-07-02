using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderRuntimeData")]
    public class IdentityDomainsIdentityProofingProviderRuntimeData : oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderRuntimeData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/identity_domains_identity_proofing_provider#attr_name IdentityDomainsIdentityProofingProvider#attr_name}.</summary>
        [JsiiProperty(name: "attrName", typeJson: "{\"primitive\":\"string\"}")]
        public string AttrName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/identity_domains_identity_proofing_provider#attr_value IdentityDomainsIdentityProofingProvider#attr_value}.</summary>
        [JsiiProperty(name: "attrValue", typeJson: "{\"primitive\":\"string\"}")]
        public string AttrValue
        {
            get;
            set;
        }
    }
}
