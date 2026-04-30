using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig : aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig
    {
        private object? _customOauth2ProviderConfig;

        /// <summary>custom_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#custom_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#custom_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomOauth2ProviderConfig
        {
            get => _customOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customOauth2ProviderConfig = value;
            }
        }

        private object? _githubOauth2ProviderConfig;

        /// <summary>github_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#github_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#github_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "githubOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GithubOauth2ProviderConfig
        {
            get => _githubOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _githubOauth2ProviderConfig = value;
            }
        }

        private object? _googleOauth2ProviderConfig;

        /// <summary>google_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#google_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#google_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GoogleOauth2ProviderConfig
        {
            get => _googleOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _googleOauth2ProviderConfig = value;
            }
        }

        private object? _microsoftOauth2ProviderConfig;

        /// <summary>microsoft_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#microsoft_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#microsoft_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MicrosoftOauth2ProviderConfig
        {
            get => _microsoftOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _microsoftOauth2ProviderConfig = value;
            }
        }

        private object? _salesforceOauth2ProviderConfig;

        /// <summary>salesforce_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#salesforce_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#salesforce_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "salesforceOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SalesforceOauth2ProviderConfig
        {
            get => _salesforceOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _salesforceOauth2ProviderConfig = value;
            }
        }

        private object? _slackOauth2ProviderConfig;

        /// <summary>slack_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_oauth2_credential_provider#slack_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#slack_oauth2_provider_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slackOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SlackOauth2ProviderConfig
        {
            get => _slackOauth2ProviderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slackOauth2ProviderConfig = value;
            }
        }
    }
}
