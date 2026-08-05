using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnics")]
    public class ContainerengineNodePoolSecondaryVnics : oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnics
    {
        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_node_pool#create_vnic_details ContainerengineNodePool#create_vnic_details}
        /// </remarks>
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetails\"}")]
        public oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetails CreateVnicDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_node_pool#display_name ContainerengineNodePool#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/containerengine_node_pool#nic_index ContainerengineNodePool#nic_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NicIndex
        {
            get;
            set;
        }
    }
}
