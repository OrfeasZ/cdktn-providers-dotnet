using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthToken
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthTokenTags), fullyQualifiedName: "oci.identityDomainsAuthToken.IdentityDomainsAuthTokenTags")]
    public interface IIdentityDomainsAuthTokenTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#key IdentityDomainsAuthToken#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#value IdentityDomainsAuthToken#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthTokenTags), fullyQualifiedName: "oci.identityDomainsAuthToken.IdentityDomainsAuthTokenTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthToken.IIdentityDomainsAuthTokenTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#key IdentityDomainsAuthToken#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#value IdentityDomainsAuthToken#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
