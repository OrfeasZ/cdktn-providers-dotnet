using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPasswordPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups")]
    public class IdentityDomainsPasswordPolicyGroups : oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#value IdentityDomainsPasswordPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
