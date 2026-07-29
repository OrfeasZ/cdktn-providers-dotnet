using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    [JsiiByValue(fqn: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderTimeouts")]
    public class IdentityDomainsIdentityProofingProviderTimeouts : oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_proofing_provider#create IdentityDomainsIdentityProofingProvider#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_proofing_provider#delete IdentityDomainsIdentityProofingProvider#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_proofing_provider#update IdentityDomainsIdentityProofingProvider#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
