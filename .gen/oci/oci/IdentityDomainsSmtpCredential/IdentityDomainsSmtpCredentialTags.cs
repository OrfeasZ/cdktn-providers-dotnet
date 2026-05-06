using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSmtpCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTags")]
    public class IdentityDomainsSmtpCredentialTags : oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#key IdentityDomainsSmtpCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#value IdentityDomainsSmtpCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
