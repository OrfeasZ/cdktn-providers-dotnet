using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterRemoteNetworkConfig")]
    public class EksClusterRemoteNetworkConfig : aws.EksCluster.IEksClusterRemoteNetworkConfig
    {
        /// <summary>remote_node_networks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/eks_cluster#remote_node_networks EksCluster#remote_node_networks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteNodeNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks? RemoteNodeNetworks
        {
            get;
            set;
        }

        /// <summary>remote_pod_networks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/eks_cluster#remote_pod_networks EksCluster#remote_pod_networks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remotePodNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks? RemotePodNetworks
        {
            get;
            set;
        }
    }
}
