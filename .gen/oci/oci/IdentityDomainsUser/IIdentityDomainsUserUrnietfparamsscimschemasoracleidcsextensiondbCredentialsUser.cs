using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#db_user_name IdentityDomainsUser#db_user_name}.</summary>
        [JsiiProperty(name: "dbUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbUserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#db_user_name IdentityDomainsUser#db_user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbUserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
