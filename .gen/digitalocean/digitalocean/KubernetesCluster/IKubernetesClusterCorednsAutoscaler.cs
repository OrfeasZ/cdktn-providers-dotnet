using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterCorednsAutoscaler), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterCorednsAutoscaler")]
    public interface IKubernetesClusterCorednsAutoscaler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.92.0/docs/resources/kubernetes_cluster#enabled KubernetesCluster#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterCorednsAutoscaler), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterCorednsAutoscaler")]
        internal sealed class _Proxy : DeputyBase, digitalocean.KubernetesCluster.IKubernetesClusterCorednsAutoscaler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.92.0/docs/resources/kubernetes_cluster#enabled KubernetesCluster#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
