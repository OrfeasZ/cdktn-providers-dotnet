using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreRegistry
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreRegistryApprovalConfiguration), fullyQualifiedName: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryApprovalConfiguration")]
    public interface IBedrockagentcoreRegistryApprovalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_registry#auto_approval BedrockagentcoreRegistry#auto_approval}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoApproval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreRegistryApprovalConfiguration), fullyQualifiedName: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryApprovalConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryApprovalConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_registry#auto_approval BedrockagentcoreRegistry#auto_approval}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoApproval
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
