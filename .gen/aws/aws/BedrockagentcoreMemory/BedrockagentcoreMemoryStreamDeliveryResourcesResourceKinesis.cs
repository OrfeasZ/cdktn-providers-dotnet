using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis")]
    public class BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis : aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_memory#data_stream_arn BedrockagentcoreMemory#data_stream_arn}.</summary>
        [JsiiProperty(name: "dataStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataStreamArn
        {
            get;
            set;
        }

        private object? _contentConfiguration;

        /// <summary>content_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_memory#content_configuration BedrockagentcoreMemory#content_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContentConfiguration
        {
            get => _contentConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _contentConfiguration = value;
            }
        }
    }
}
