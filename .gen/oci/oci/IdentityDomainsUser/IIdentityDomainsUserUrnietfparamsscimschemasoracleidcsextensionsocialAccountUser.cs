using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
    {
        /// <summary>social_accounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#social_accounts IdentityDomainsUser#social_accounts}
        /// </remarks>
        [JsiiProperty(name: "socialAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserSocialAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SocialAccounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>social_accounts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#social_accounts IdentityDomainsUser#social_accounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socialAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserSocialAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SocialAccounts
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
