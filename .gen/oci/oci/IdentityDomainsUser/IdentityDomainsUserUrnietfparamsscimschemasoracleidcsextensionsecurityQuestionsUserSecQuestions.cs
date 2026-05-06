using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserSecQuestions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#answer IdentityDomainsUser#answer}.</summary>
        [JsiiProperty(name: "answer", typeJson: "{\"primitive\":\"string\"}")]
        public string Answer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#hint_text IdentityDomainsUser#hint_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hintText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HintText
        {
            get;
            set;
        }
    }
}
