using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiByValue(fqn: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabels")]
    public class ContainerengineVirtualNodePoolInitialVirtualNodeLabels : oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolInitialVirtualNodeLabels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#key ContainerengineVirtualNodePool#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#value ContainerengineVirtualNodePool#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
