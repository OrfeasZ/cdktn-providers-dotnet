using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesNodePool
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodePoolTaint), fullyQualifiedName: "digitalocean.kubernetesNodePool.KubernetesNodePoolTaint")]
    public interface IKubernetesNodePoolTaint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#effect KubernetesNodePool#effect}.</summary>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        string Effect
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#key KubernetesNodePool#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#value KubernetesNodePool#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodePoolTaint), fullyQualifiedName: "digitalocean.kubernetesNodePool.KubernetesNodePoolTaint")]
        internal sealed class _Proxy : DeputyBase, digitalocean.KubernetesNodePool.IKubernetesNodePoolTaint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#effect KubernetesNodePool#effect}.</summary>
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
            public string Effect
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#key KubernetesNodePool#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_node_pool#value KubernetesNodePool#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
