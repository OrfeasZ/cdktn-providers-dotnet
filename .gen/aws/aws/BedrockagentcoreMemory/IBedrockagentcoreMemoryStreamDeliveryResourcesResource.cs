using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResourcesResource), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource")]
    public interface IBedrockagentcoreMemoryStreamDeliveryResourcesResource
    {
        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_memory#kinesis BedrockagentcoreMemory#kinesis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Kinesis
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResourcesResource), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_memory#kinesis BedrockagentcoreMemory#kinesis}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Kinesis
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
