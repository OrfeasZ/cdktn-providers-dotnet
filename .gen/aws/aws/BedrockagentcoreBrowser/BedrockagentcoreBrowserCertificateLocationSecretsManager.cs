using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager")]
    public class BedrockagentcoreBrowserCertificateLocationSecretsManager : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/bedrockagentcore_browser#secret_arn BedrockagentcoreBrowser#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretArn
        {
            get;
            set;
        }
    }
}
