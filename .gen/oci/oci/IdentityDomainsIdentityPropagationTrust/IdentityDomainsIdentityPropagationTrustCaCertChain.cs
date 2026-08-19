using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChain")]
    public class IdentityDomainsIdentityPropagationTrustCaCertChain : oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustCaCertChain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_propagation_trust#root_cas IdentityDomainsIdentityPropagationTrust#root_cas}.</summary>
        [JsiiProperty(name: "rootCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RootCas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_propagation_trust#intermediate_cas IdentityDomainsIdentityPropagationTrust#intermediate_cas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intermediateCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IntermediateCas
        {
            get;
            set;
        }
    }
}
