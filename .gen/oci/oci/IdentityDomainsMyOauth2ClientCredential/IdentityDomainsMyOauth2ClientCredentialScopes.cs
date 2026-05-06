using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyOauth2ClientCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyOauth2ClientCredential.IdentityDomainsMyOauth2ClientCredentialScopes")]
    public class IdentityDomainsMyOauth2ClientCredentialScopes : oci.IdentityDomainsMyOauth2ClientCredential.IIdentityDomainsMyOauth2ClientCredentialScopes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#audience IdentityDomainsMyOauth2ClientCredential#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public string Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#scope IdentityDomainsMyOauth2ClientCredential#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public string Scope
        {
            get;
            set;
        }
    }
}
