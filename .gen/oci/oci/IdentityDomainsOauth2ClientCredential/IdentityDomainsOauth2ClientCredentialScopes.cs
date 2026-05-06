using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsOauth2ClientCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsOauth2ClientCredential.IdentityDomainsOauth2ClientCredentialScopes")]
    public class IdentityDomainsOauth2ClientCredentialScopes : oci.IdentityDomainsOauth2ClientCredential.IIdentityDomainsOauth2ClientCredentialScopes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#audience IdentityDomainsOauth2ClientCredential#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public string Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#scope IdentityDomainsOauth2ClientCredential#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public string Scope
        {
            get;
            set;
        }
    }
}
