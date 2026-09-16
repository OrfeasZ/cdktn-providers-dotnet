using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig : aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_credentials_wo_version BedrockagentcoreOauth2CredentialProvider#client_credentials_wo_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCredentialsWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClientCredentialsWoVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_id BedrockagentcoreOauth2CredentialProvider#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_id_wo BedrockagentcoreOauth2CredentialProvider#client_id_wo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientIdWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientIdWo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_secret BedrockagentcoreOauth2CredentialProvider#client_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        private object? _clientSecretConfig;

        /// <summary>client_secret_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_secret_config BedrockagentcoreOauth2CredentialProvider#client_secret_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClientSecretConfig
        {
            get => _clientSecretConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientSecretConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_secret_source BedrockagentcoreOauth2CredentialProvider#client_secret_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#client_secret_wo BedrockagentcoreOauth2CredentialProvider#client_secret_wo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretWo
        {
            get;
            set;
        }
    }
}
