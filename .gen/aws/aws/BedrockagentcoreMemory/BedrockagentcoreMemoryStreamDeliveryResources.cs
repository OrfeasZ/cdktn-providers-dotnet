using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResources")]
    public class BedrockagentcoreMemoryStreamDeliveryResources : aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResources
    {
        private object? _resource;

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_memory#resource BedrockagentcoreMemory#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Resource
        {
            get => _resource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resource = value;
            }
        }
    }
}
