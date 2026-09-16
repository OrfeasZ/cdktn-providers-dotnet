using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig : aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#json_key BedrockagentcoreOauth2CredentialProvider#json_key}.</summary>
        [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#secret_id BedrockagentcoreOauth2CredentialProvider#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }
    }
}
