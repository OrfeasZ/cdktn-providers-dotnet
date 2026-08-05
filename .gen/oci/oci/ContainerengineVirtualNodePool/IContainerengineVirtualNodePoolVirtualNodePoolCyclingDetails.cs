using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails")]
    public interface IContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#is_virtual_node_cycling_enabled ContainerengineVirtualNodePool#is_virtual_node_cycling_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isVirtualNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsVirtualNodeCyclingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#maximum_surge ContainerengineVirtualNodePool#maximum_surge}.</summary>
        [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumSurge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#maximum_unavailable ContainerengineVirtualNodePool#maximum_unavailable}.</summary>
        [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumUnavailable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#is_virtual_node_cycling_enabled ContainerengineVirtualNodePool#is_virtual_node_cycling_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isVirtualNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsVirtualNodeCyclingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#maximum_surge ContainerengineVirtualNodePool#maximum_surge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumSurge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_virtual_node_pool#maximum_unavailable ContainerengineVirtualNodePool#maximum_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumUnavailable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
