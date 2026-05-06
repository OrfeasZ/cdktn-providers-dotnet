using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails")]
    public class ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails : oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cni_type ContainerengineNodePool#cni_type}.</summary>
        [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
        public string CniType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#max_pods_per_node ContainerengineNodePool#max_pods_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPodsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPodsPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_nsg_ids ContainerengineNodePool#pod_nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PodNsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_subnet_ids ContainerengineNodePool#pod_subnet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PodSubnetIds
        {
            get;
            set;
        }
    }
}
