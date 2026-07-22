using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource")]
    public class BedrockagentcoreMemoryStreamDeliveryResourcesResource : aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource
    {
        private object? _kinesis;

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/bedrockagentcore_memory#kinesis BedrockagentcoreMemory#kinesis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Kinesis
        {
            get => _kinesis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kinesis = value;
            }
        }
    }
}
