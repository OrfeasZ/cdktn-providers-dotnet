using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfiguration")]
    public class BedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrockagent_data_source#model_arn BedrockagentDataSource#model_arn}.</summary>
        [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelArn
        {
            get;
            set;
        }

        private object? _enrichmentStrategyConfiguration;

        /// <summary>enrichment_strategy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrockagent_data_source#enrichment_strategy_configuration BedrockagentDataSource#enrichment_strategy_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfigurationEnrichmentStrategyConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enrichmentStrategyConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfigurationEnrichmentStrategyConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnrichmentStrategyConfiguration
        {
            get => _enrichmentStrategyConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfigurationEnrichmentStrategyConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationContextEnrichmentConfigurationBedrockFoundationModelConfigurationEnrichmentStrategyConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enrichmentStrategyConfiguration = value;
            }
        }
    }
}
