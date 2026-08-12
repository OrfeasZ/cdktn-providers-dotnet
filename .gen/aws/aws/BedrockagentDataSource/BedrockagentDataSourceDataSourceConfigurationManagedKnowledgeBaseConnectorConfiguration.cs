using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagent_data_source#connector_parameters BedrockagentDataSource#connector_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorParameters
        {
            get;
            set;
        }

        private object? _deletionProtectionConfiguration;

        /// <summary>deletion_protection_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagent_data_source#deletion_protection_configuration BedrockagentDataSource#deletion_protection_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeletionProtectionConfiguration
        {
            get => _deletionProtectionConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deletionProtectionConfiguration = value;
            }
        }

        private object? _mediaExtractionConfiguration;

        /// <summary>media_extraction_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagent_data_source#media_extraction_configuration BedrockagentDataSource#media_extraction_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mediaExtractionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MediaExtractionConfiguration
        {
            get => _mediaExtractionConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mediaExtractionConfiguration = value;
            }
        }
    }
}
