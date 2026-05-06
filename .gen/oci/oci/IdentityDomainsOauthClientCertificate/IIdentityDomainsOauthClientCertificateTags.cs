using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsOauthClientCertificate
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsOauthClientCertificateTags), fullyQualifiedName: "oci.identityDomainsOauthClientCertificate.IdentityDomainsOauthClientCertificateTags")]
    public interface IIdentityDomainsOauthClientCertificateTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth_client_certificate#key IdentityDomainsOauthClientCertificate#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth_client_certificate#value IdentityDomainsOauthClientCertificate#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsOauthClientCertificateTags), fullyQualifiedName: "oci.identityDomainsOauthClientCertificate.IdentityDomainsOauthClientCertificateTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsOauthClientCertificate.IIdentityDomainsOauthClientCertificateTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth_client_certificate#key IdentityDomainsOauthClientCertificate#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_oauth_client_certificate#value IdentityDomainsOauthClientCertificate#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
