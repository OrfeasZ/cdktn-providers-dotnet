using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#sff_auth_keys IdentityDomainsUser#sff_auth_keys}.</summary>
        [JsiiProperty(name: "sffAuthKeys", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SffAuthKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#sff_auth_keys IdentityDomainsUser#sff_auth_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sffAuthKeys", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SffAuthKeys
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
