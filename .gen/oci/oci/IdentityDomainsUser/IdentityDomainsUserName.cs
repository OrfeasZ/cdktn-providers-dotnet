using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserName")]
    public class IdentityDomainsUserName : oci.IdentityDomainsUser.IIdentityDomainsUserName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#family_name IdentityDomainsUser#family_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FamilyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#formatted IdentityDomainsUser#formatted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Formatted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#given_name IdentityDomainsUser#given_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GivenName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_prefix IdentityDomainsUser#honorific_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HonorificPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_suffix IdentityDomainsUser#honorific_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HonorificSuffix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#middle_name IdentityDomainsUser#middle_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MiddleName
        {
            get;
            set;
        }
    }
}
