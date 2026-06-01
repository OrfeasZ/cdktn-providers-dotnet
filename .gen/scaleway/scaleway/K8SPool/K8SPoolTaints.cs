using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.k8SPool.K8SPoolTaints")]
    public class K8SPoolTaints : scaleway.K8SPool.IK8SPoolTaints
    {
        /// <summary>Effect of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#effect K8SPool#effect}
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        public string Effect
        {
            get;
            set;
        }

        /// <summary>Key of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#key K8SPool#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Value of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#value K8SPool#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
