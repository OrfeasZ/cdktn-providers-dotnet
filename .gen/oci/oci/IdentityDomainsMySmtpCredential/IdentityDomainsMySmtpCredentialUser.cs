using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMySmtpCredential
{
    [JsiiByValue(fqn: "oci.identityDomainsMySmtpCredential.IdentityDomainsMySmtpCredentialUser")]
    public class IdentityDomainsMySmtpCredentialUser : oci.IdentityDomainsMySmtpCredential.IIdentityDomainsMySmtpCredentialUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#ocid IdentityDomainsMySmtpCredential#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#value IdentityDomainsMySmtpCredential#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
