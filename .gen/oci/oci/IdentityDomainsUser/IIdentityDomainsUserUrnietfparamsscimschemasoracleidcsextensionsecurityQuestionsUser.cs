using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
    {
        /// <summary>sec_questions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#sec_questions IdentityDomainsUser#sec_questions}
        /// </remarks>
        [JsiiProperty(name: "secQuestions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecQuestions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sec_questions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#sec_questions IdentityDomainsUser#sec_questions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secQuestions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecQuestions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
