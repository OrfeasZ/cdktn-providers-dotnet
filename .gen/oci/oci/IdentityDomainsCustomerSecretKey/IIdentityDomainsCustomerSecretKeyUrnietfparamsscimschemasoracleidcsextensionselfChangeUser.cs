using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCustomerSecretKey
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser), fullyQualifiedName: "oci.identityDomainsCustomerSecretKey.IdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
    public interface IIdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_customer_secret_key#allow_self_change IdentityDomainsCustomerSecretKey#allow_self_change}.</summary>
        [JsiiProperty(name: "allowSelfChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowSelfChange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser), fullyQualifiedName: "oci.identityDomainsCustomerSecretKey.IdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCustomerSecretKey.IIdentityDomainsCustomerSecretKeyUrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_customer_secret_key#allow_self_change IdentityDomainsCustomerSecretKey#allow_self_change}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowSelfChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowSelfChange
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
