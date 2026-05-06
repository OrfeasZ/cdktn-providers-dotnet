using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails")]
    public interface IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cni_type ContainerengineNodePool#cni_type}.</summary>
        [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
        string CniType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#max_pods_per_node ContainerengineNodePool#max_pods_per_node}.</summary>
        [JsiiProperty(name: "maxPodsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPodsPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_nsg_ids ContainerengineNodePool#pod_nsg_ids}.</summary>
        [JsiiProperty(name: "podNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PodNsgIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_subnet_ids ContainerengineNodePool#pod_subnet_ids}.</summary>
        [JsiiProperty(name: "podSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PodSubnetIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cni_type ContainerengineNodePool#cni_type}.</summary>
            [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
            public string CniType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#max_pods_per_node ContainerengineNodePool#max_pods_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPodsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPodsPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_nsg_ids ContainerengineNodePool#pod_nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PodNsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#pod_subnet_ids ContainerengineNodePool#pod_subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PodSubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
