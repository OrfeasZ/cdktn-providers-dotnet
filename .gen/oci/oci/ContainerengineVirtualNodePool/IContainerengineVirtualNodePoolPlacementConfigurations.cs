using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineVirtualNodePoolPlacementConfigurations), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurations")]
    public interface IContainerengineVirtualNodePoolPlacementConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#availability_domain ContainerengineVirtualNodePool#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#fault_domain ContainerengineVirtualNodePool#fault_domain}.</summary>
        [JsiiProperty(name: "faultDomain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] FaultDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#subnet_id ContainerengineVirtualNodePool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineVirtualNodePoolPlacementConfigurations), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPlacementConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#availability_domain ContainerengineVirtualNodePool#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#fault_domain ContainerengineVirtualNodePool#fault_domain}.</summary>
            [JsiiProperty(name: "faultDomain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] FaultDomain
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#subnet_id ContainerengineVirtualNodePool#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
