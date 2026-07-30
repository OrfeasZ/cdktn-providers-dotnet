using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccess")]
    public class KubernetesAutomaticClusterApiServerAccess : azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_automatic_cluster#authorized_ip_ranges KubernetesAutomaticCluster#authorized_ip_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizedIpRanges
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_automatic_cluster#subnet_id KubernetesAutomaticCluster#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
