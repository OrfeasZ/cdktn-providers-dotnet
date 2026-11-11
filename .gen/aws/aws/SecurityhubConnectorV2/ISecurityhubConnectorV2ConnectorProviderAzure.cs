using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderAzure), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzure")]
    public interface ISecurityhubConnectorV2ConnectorProviderAzure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#aws_config_connector_arn SecurityhubConnectorV2#aws_config_connector_arn}.</summary>
        [JsiiProperty(name: "awsConfigConnectorArn", typeJson: "{\"primitive\":\"string\"}")]
        string AwsConfigConnectorArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#azure_regions SecurityhubConnectorV2#azure_regions}.</summary>
        [JsiiProperty(name: "azureRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AzureRegions
        {
            get;
        }

        /// <summary>scope_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_configuration SecurityhubConnectorV2#scope_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scopeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScopeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderAzure), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzure")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#aws_config_connector_arn SecurityhubConnectorV2#aws_config_connector_arn}.</summary>
            [JsiiProperty(name: "awsConfigConnectorArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AwsConfigConnectorArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#azure_regions SecurityhubConnectorV2#azure_regions}.</summary>
            [JsiiProperty(name: "azureRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AzureRegions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>scope_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_configuration SecurityhubConnectorV2#scope_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScopeConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
