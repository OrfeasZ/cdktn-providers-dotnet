using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyAuthToken
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyAuthTokenTags), fullyQualifiedName: "oci.identityDomainsMyAuthToken.IdentityDomainsMyAuthTokenTags")]
    public interface IIdentityDomainsMyAuthTokenTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#key IdentityDomainsMyAuthToken#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#value IdentityDomainsMyAuthToken#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyAuthTokenTags), fullyQualifiedName: "oci.identityDomainsMyAuthToken.IdentityDomainsMyAuthTokenTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyAuthToken.IIdentityDomainsMyAuthTokenTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#key IdentityDomainsMyAuthToken#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#value IdentityDomainsMyAuthToken#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
