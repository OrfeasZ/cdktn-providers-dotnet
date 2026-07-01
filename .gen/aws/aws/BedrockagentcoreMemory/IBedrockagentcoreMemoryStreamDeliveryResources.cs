using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemory
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResources), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResources")]
    public interface IBedrockagentcoreMemoryStreamDeliveryResources
    {
        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_memory#resource BedrockagentcoreMemory#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStreamDeliveryResources), fullyQualifiedName: "aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResources")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_memory#resource BedrockagentcoreMemory#resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemory.IBedrockagentcoreMemoryStreamDeliveryResourcesResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemory.BedrockagentcoreMemoryStreamDeliveryResourcesResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Resource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
