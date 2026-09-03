using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterNodePoolWindowsProfile), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolWindowsProfile")]
    public interface IKubernetesClusterNodePoolWindowsProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_node_pool#outbound_nat_enabled KubernetesClusterNodePool#outbound_nat_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "outboundNatEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutboundNatEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterNodePoolWindowsProfile), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolWindowsProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolWindowsProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_node_pool#outbound_nat_enabled KubernetesClusterNodePool#outbound_nat_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outboundNatEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OutboundNatEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
