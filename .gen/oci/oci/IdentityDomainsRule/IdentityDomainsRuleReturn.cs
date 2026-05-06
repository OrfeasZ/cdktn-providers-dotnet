using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsRule.IdentityDomainsRuleReturn")]
    public class IdentityDomainsRuleReturn : oci.IdentityDomainsRule.IIdentityDomainsRuleReturn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#name IdentityDomainsRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#value IdentityDomainsRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#return_groovy IdentityDomainsRule#return_groovy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "returnGroovy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnGroovy
        {
            get;
            set;
        }
    }
}
