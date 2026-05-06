using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
    {
        private object? _secQuestions;

        /// <summary>sec_questions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#sec_questions IdentityDomainsUser#sec_questions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secQuestions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecQuestions
        {
            get => _secQuestions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secQuestions = value;
            }
        }
    }
}
