using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolNodeEvictionNodePoolSettings), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettings")]
    public interface IContainerengineNodePoolNodeEvictionNodePoolSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#eviction_grace_duration ContainerengineNodePool#eviction_grace_duration}.</summary>
        [JsiiProperty(name: "evictionGraceDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvictionGraceDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_action_after_grace_duration ContainerengineNodePool#is_force_action_after_grace_duration}.</summary>
        [JsiiProperty(name: "isForceActionAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForceActionAfterGraceDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_delete_after_grace_duration ContainerengineNodePool#is_force_delete_after_grace_duration}.</summary>
        [JsiiProperty(name: "isForceDeleteAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForceDeleteAfterGraceDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolNodeEvictionNodePoolSettings), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettings")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#eviction_grace_duration ContainerengineNodePool#eviction_grace_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evictionGraceDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvictionGraceDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_action_after_grace_duration ContainerengineNodePool#is_force_action_after_grace_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForceActionAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForceActionAfterGraceDuration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_delete_after_grace_duration ContainerengineNodePool#is_force_delete_after_grace_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForceDeleteAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForceDeleteAfterGraceDuration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
