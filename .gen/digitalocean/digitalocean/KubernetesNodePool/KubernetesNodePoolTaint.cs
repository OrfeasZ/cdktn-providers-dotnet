using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.kubernetesNodePool.KubernetesNodePoolTaint")]
    public class KubernetesNodePoolTaint : digitalocean.KubernetesNodePool.IKubernetesNodePoolTaint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#effect KubernetesNodePool#effect}.</summary>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        public string Effect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#key KubernetesNodePool#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#value KubernetesNodePool#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
