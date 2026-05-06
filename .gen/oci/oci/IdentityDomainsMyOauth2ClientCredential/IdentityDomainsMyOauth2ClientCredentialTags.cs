using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyOauth2ClientCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyOauth2ClientCredential.IdentityDomainsMyOauth2ClientCredentialTags")]
    public class IdentityDomainsMyOauth2ClientCredentialTags : oci.IdentityDomainsMyOauth2ClientCredential.IIdentityDomainsMyOauth2ClientCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#key IdentityDomainsMyOauth2ClientCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#value IdentityDomainsMyOauth2ClientCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
