using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthToken
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser), fullyQualifiedName: "oci.identityDomainsAuthToken.IdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
    public interface IIdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#allow_self_change IdentityDomainsAuthToken#allow_self_change}.</summary>
        [JsiiProperty(name: "allowSelfChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowSelfChange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser), fullyQualifiedName: "oci.identityDomainsAuthToken.IdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthToken.IIdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#allow_self_change IdentityDomainsAuthToken#allow_self_change}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowSelfChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowSelfChange
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
