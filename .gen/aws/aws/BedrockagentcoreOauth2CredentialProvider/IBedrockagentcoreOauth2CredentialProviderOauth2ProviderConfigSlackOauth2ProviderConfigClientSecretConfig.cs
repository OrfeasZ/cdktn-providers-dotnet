using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig")]
    public interface IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#json_key BedrockagentcoreOauth2CredentialProvider#json_key}.</summary>
        [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
        string JsonKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#secret_id BedrockagentcoreOauth2CredentialProvider#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#json_key BedrockagentcoreOauth2CredentialProvider#json_key}.</summary>
            [JsiiProperty(name: "jsonKey", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#secret_id BedrockagentcoreOauth2CredentialProvider#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
