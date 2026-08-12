using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProviderTemplate
{
    [JsiiByValue(fqn: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeouts")]
    public class IdentityDomainsIdentityProofingProviderTemplateTimeouts : oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#create IdentityDomainsIdentityProofingProviderTemplate#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#delete IdentityDomainsIdentityProofingProviderTemplate#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#update IdentityDomainsIdentityProofingProviderTemplate#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
