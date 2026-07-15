using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
    {
        /// <summary>terms_of_use_consents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_user#terms_of_use_consents IdentityDomainsUser#terms_of_use_consents}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserTermsOfUseConsents" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "termsOfUseConsents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserTermsOfUseConsents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TermsOfUseConsents
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>terms_of_use_consents block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_user#terms_of_use_consents IdentityDomainsUser#terms_of_use_consents}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserTermsOfUseConsents" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfUseConsents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserTermsOfUseConsents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TermsOfUseConsents
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
