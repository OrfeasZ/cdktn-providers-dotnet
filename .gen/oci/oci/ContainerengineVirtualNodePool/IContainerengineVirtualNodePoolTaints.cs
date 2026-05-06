using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineVirtualNodePoolTaints), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTaints")]
    public interface IContainerengineVirtualNodePoolTaints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#effect ContainerengineVirtualNodePool#effect}.</summary>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Effect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#key ContainerengineVirtualNodePool#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#value ContainerengineVirtualNodePool#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineVirtualNodePoolTaints), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTaints")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTaints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#effect ContainerengineVirtualNodePool#effect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Effect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#key ContainerengineVirtualNodePool#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#value ContainerengineVirtualNodePool#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
