using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustImpersonationServiceUsers")]
    public class IdentityDomainsIdentityPropagationTrustImpersonationServiceUsers : oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustImpersonationServiceUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#rule IdentityDomainsIdentityPropagationTrust#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public string Rule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#value IdentityDomainsIdentityPropagationTrust#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#ocid IdentityDomainsIdentityPropagationTrust#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }
    }
}
