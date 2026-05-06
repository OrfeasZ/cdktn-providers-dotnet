using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsOauth2ClientCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsOauth2ClientCredential.IdentityDomainsOauth2ClientCredentialTags")]
    public class IdentityDomainsOauth2ClientCredentialTags : oci.IdentityDomainsOauth2ClientCredential.IIdentityDomainsOauth2ClientCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#key IdentityDomainsOauth2ClientCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#value IdentityDomainsOauth2ClientCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
