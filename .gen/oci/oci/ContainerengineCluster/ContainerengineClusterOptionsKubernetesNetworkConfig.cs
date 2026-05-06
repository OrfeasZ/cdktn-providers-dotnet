using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig")]
    public class ContainerengineClusterOptionsKubernetesNetworkConfig : oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#pods_cidr ContainerengineCluster#pods_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podsCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PodsCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#services_cidr ContainerengineCluster#services_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "servicesCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServicesCidr
        {
            get;
            set;
        }
    }
}
