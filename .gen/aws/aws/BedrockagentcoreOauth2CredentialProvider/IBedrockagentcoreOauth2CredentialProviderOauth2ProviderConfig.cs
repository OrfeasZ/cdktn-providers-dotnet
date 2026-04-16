using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig")]
    public interface IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig
    {
        /// <summary>custom_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#custom_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#custom_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "customOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>github_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#github_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#github_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "githubOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GithubOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>google_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#google_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#google_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "googleOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GoogleOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#microsoft_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#microsoft_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "microsoftOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MicrosoftOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>salesforce_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#salesforce_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#salesforce_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "salesforceOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SalesforceOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>slack_oauth2_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#slack_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#slack_oauth2_provider_config}
        /// </remarks>
        [JsiiProperty(name: "slackOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SlackOauth2ProviderConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#custom_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#custom_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>github_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#github_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#github_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "githubOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GithubOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>google_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#google_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#google_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "googleOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GoogleOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>microsoft_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#microsoft_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#microsoft_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MicrosoftOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>salesforce_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#salesforce_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#salesforce_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "salesforceOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SalesforceOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>slack_oauth2_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_oauth2_credential_provider#slack_oauth2_provider_config BedrockagentcoreOauth2CredentialProvider#slack_oauth2_provider_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slackOauth2ProviderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlackOauth2ProviderConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
