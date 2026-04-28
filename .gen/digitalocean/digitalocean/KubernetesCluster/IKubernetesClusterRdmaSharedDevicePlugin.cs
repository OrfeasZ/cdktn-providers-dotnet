using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterRdmaSharedDevicePlugin), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin")]
    public interface IKubernetesClusterRdmaSharedDevicePlugin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/kubernetes_cluster#enabled KubernetesCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterRdmaSharedDevicePlugin), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin")]
        internal sealed class _Proxy : DeputyBase, digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/kubernetes_cluster#enabled KubernetesCluster#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
