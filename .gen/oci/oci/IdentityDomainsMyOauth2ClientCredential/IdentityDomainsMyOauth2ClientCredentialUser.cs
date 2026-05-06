using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyOauth2ClientCredential
{
    [JsiiByValue(fqn: "oci.identityDomainsMyOauth2ClientCredential.IdentityDomainsMyOauth2ClientCredentialUser")]
    public class IdentityDomainsMyOauth2ClientCredentialUser : oci.IdentityDomainsMyOauth2ClientCredential.IIdentityDomainsMyOauth2ClientCredentialUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#ocid IdentityDomainsMyOauth2ClientCredential#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#value IdentityDomainsMyOauth2ClientCredential#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
