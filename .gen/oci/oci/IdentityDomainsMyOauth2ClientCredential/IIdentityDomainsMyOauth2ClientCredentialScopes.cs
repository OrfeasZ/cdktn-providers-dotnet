using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyOauth2ClientCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyOauth2ClientCredentialScopes), fullyQualifiedName: "oci.identityDomainsMyOauth2ClientCredential.IdentityDomainsMyOauth2ClientCredentialScopes")]
    public interface IIdentityDomainsMyOauth2ClientCredentialScopes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#audience IdentityDomainsMyOauth2ClientCredential#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#scope IdentityDomainsMyOauth2ClientCredential#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyOauth2ClientCredentialScopes), fullyQualifiedName: "oci.identityDomainsMyOauth2ClientCredential.IdentityDomainsMyOauth2ClientCredentialScopes")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyOauth2ClientCredential.IIdentityDomainsMyOauth2ClientCredentialScopes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#audience IdentityDomainsMyOauth2ClientCredential#audience}.</summary>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_oauth2client_credential#scope IdentityDomainsMyOauth2ClientCredential#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
