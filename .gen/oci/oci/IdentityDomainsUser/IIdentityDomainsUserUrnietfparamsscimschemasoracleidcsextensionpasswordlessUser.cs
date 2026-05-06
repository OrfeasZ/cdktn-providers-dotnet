using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
    {
        /// <summary>factor_identifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_identifier IdentityDomainsUser#factor_identifier}
        /// </remarks>
        [JsiiProperty(name: "factorIdentifier", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier? FactorIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_method IdentityDomainsUser#factor_method}.</summary>
        [JsiiProperty(name: "factorMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FactorMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_type IdentityDomainsUser#factor_type}.</summary>
        [JsiiProperty(name: "factorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FactorType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>factor_identifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_identifier IdentityDomainsUser#factor_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "factorIdentifier", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier? FactorIdentifier
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_method IdentityDomainsUser#factor_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "factorMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FactorMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_type IdentityDomainsUser#factor_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "factorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FactorType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
