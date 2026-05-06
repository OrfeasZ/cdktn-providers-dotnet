using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
    {
        /// <summary>realm_users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#realm_users IdentityDomainsUser#realm_users}
        /// </remarks>
        [JsiiProperty(name: "realmUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserRealmUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RealmUsers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>realm_users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#realm_users IdentityDomainsUser#realm_users}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "realmUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserRealmUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RealmUsers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
