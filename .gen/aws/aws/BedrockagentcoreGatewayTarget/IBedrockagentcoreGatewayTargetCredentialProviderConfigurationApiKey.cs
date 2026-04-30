using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey")]
    public interface IBedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
        [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_location BedrockagentcoreGatewayTarget#credential_location}.</summary>
        [JsiiProperty(name: "credentialLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_parameter_name BedrockagentcoreGatewayTarget#credential_parameter_name}.</summary>
        [JsiiProperty(name: "credentialParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialParameterName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_prefix BedrockagentcoreGatewayTarget#credential_prefix}.</summary>
        [JsiiProperty(name: "credentialPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
            [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_location BedrockagentcoreGatewayTarget#credential_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_parameter_name BedrockagentcoreGatewayTarget#credential_parameter_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialParameterName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#credential_prefix BedrockagentcoreGatewayTarget#credential_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
