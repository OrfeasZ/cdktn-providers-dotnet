using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzure")]
    public class SecurityhubConnectorV2ConnectorProviderAzure : aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#aws_config_connector_arn SecurityhubConnectorV2#aws_config_connector_arn}.</summary>
        [JsiiProperty(name: "awsConfigConnectorArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsConfigConnectorArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#azure_regions SecurityhubConnectorV2#azure_regions}.</summary>
        [JsiiProperty(name: "azureRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AzureRegions
        {
            get;
            set;
        }

        private object? _scopeConfiguration;

        /// <summary>scope_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_configuration SecurityhubConnectorV2#scope_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScopeConfiguration
        {
            get => _scopeConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scopeConfiguration = value;
            }
        }
    }
}
