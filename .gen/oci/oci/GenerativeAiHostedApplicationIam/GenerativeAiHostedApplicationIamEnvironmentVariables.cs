using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamEnvironmentVariables")]
    public class GenerativeAiHostedApplicationIamEnvironmentVariables : oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamEnvironmentVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#name GenerativeAiHostedApplicationIam#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#type GenerativeAiHostedApplicationIam#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#value GenerativeAiHostedApplicationIam#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
