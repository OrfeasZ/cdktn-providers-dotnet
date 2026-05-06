using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytab")]
    public class IdentityDomainsIdentityPropagationTrustKeytab : oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustKeytab
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_ocid IdentityDomainsIdentityPropagationTrust#secret_ocid}.</summary>
        [JsiiProperty(name: "secretOcid", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretOcid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_version IdentityDomainsIdentityPropagationTrust#secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SecretVersion
        {
            get;
            set;
        }
    }
}
