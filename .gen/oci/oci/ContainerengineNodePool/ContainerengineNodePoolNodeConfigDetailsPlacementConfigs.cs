using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigs")]
    public class ContainerengineNodePoolNodeConfigDetailsPlacementConfigs : oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#availability_domain ContainerengineNodePool#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#subnet_id ContainerengineNodePool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#capacity_reservation_id ContainerengineNodePool#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#fault_domains ContainerengineNodePool#fault_domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FaultDomains
        {
            get;
            set;
        }

        /// <summary>preemptible_node_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#preemptible_node_config ContainerengineNodePool#preemptible_node_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preemptibleNodeConfig", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig\"}", isOptional: true)]
        public oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig? PreemptibleNodeConfig
        {
            get;
            set;
        }
    }
}
