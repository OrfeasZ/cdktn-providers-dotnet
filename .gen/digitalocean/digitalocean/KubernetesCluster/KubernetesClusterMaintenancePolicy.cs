using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    [JsiiByValue(fqn: "digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicy")]
    public class KubernetesClusterMaintenancePolicy : digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/kubernetes_cluster#day KubernetesCluster#day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/kubernetes_cluster#start_time KubernetesCluster#start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartTime
        {
            get;
            set;
        }
    }
}
