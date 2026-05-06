using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsOauth2ClientCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsOauth2ClientCredentialScopes), fullyQualifiedName: "oci.identityDomainsOauth2ClientCredential.IdentityDomainsOauth2ClientCredentialScopes")]
    public interface IIdentityDomainsOauth2ClientCredentialScopes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#audience IdentityDomainsOauth2ClientCredential#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#scope IdentityDomainsOauth2ClientCredential#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsOauth2ClientCredentialScopes), fullyQualifiedName: "oci.identityDomainsOauth2ClientCredential.IdentityDomainsOauth2ClientCredentialScopes")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsOauth2ClientCredential.IIdentityDomainsOauth2ClientCredentialScopes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#audience IdentityDomainsOauth2ClientCredential#audience}.</summary>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth2client_credential#scope IdentityDomainsOauth2ClientCredential#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
