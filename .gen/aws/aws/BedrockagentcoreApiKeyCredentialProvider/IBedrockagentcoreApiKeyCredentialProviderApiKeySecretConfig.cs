using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreApiKeyCredentialProvider
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig), fullyQualifiedName: "aws.bedrockagentcoreApiKeyCredentialProvider.BedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig")]
    public interface IBedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#json_key BedrockagentcoreApiKeyCredentialProvider#json_key}.</summary>
        [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
        string JsonKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#secret_id BedrockagentcoreApiKeyCredentialProvider#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig), fullyQualifiedName: "aws.bedrockagentcoreApiKeyCredentialProvider.BedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreApiKeyCredentialProvider.IBedrockagentcoreApiKeyCredentialProviderApiKeySecretConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#json_key BedrockagentcoreApiKeyCredentialProvider#json_key}.</summary>
            [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/bedrockagentcore_api_key_credential_provider#secret_id BedrockagentcoreApiKeyCredentialProvider#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
