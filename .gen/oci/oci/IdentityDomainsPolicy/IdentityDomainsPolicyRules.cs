using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsPolicy.IdentityDomainsPolicyRules")]
    public class IdentityDomainsPolicyRules : oci.IdentityDomainsPolicy.IIdentityDomainsPolicyRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#sequence IdentityDomainsPolicy#sequence}.</summary>
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}")]
        public double Sequence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#value IdentityDomainsPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
