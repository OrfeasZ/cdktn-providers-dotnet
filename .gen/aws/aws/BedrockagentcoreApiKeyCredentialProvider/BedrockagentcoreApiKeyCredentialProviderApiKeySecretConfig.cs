using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreApiKeyCredentialProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreApiKeyCredentialProvider.BedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig")]
    public class BedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig : aws.BedrockagentcoreApiKeyCredentialProvider.IBedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#json_key BedrockagentcoreApiKeyCredentialProvider#json_key}.</summary>
        [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#secret_id BedrockagentcoreApiKeyCredentialProvider#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }
    }
}
