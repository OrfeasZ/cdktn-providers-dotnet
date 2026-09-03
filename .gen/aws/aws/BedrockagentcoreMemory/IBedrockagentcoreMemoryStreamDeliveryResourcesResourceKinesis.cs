using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis")]
    public interface IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory#data_stream_arn BedrockagentcoreMemory#data_stream_arn}.</summary>
        [JsiiProperty(name: "dataStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataStreamArn
        {
            get;
        }

        /// <summary>content_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory#content_configuration BedrockagentcoreMemory#content_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "contentConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory#data_stream_arn BedrockagentcoreMemory#data_stream_arn}.</summary>
            [JsiiProperty(name: "dataStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>content_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory#content_configuration BedrockagentcoreMemory#content_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResourceKinesisContentConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContentConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
