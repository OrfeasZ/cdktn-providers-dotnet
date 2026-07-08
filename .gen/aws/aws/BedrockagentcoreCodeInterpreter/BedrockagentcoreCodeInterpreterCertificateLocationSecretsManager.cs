using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager")]
    public class BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager : aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/bedrockagentcore_code_interpreter#secret_arn BedrockagentcoreCodeInterpreter#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretArn
        {
            get;
            set;
        }
    }
}
