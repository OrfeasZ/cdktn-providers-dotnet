using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolNodePoolCyclingDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetails")]
    public interface IContainerengineNodePoolNodePoolCyclingDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cycle_modes ContainerengineNodePool#cycle_modes}.</summary>
        [JsiiProperty(name: "cycleModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CycleModes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_node_cycling_enabled ContainerengineNodePool#is_node_cycling_enabled}.</summary>
        [JsiiProperty(name: "isNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNodeCyclingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_surge ContainerengineNodePool#maximum_surge}.</summary>
        [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumSurge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_unavailable ContainerengineNodePool#maximum_unavailable}.</summary>
        [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumUnavailable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolNodePoolCyclingDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cycle_modes ContainerengineNodePool#cycle_modes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cycleModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CycleModes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_node_cycling_enabled ContainerengineNodePool#is_node_cycling_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsNodeCyclingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_surge ContainerengineNodePool#maximum_surge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumSurge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_unavailable ContainerengineNodePool#maximum_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumUnavailable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
