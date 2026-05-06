using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptions")]
    public class ContainerengineClusterClusterPodNetworkOptions : oci.ContainerengineCluster.IContainerengineClusterClusterPodNetworkOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#cni_type ContainerengineCluster#cni_type}.</summary>
        [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
        public string CniType
        {
            get;
            set;
        }
    }
}
