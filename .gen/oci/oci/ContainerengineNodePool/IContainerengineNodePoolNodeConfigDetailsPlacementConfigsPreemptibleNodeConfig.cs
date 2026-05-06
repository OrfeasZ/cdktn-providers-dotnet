using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig")]
    public interface IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig
    {
        /// <summary>preemption_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#preemption_action ContainerengineNodePool#preemption_action}
        /// </remarks>
        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction\"}")]
        oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction PreemptionAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>preemption_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#preemption_action ContainerengineNodePool#preemption_action}
            /// </remarks>
            [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction\"}")]
            public oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction PreemptionAction
            {
                get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction>()!;
            }
        }
    }
}
