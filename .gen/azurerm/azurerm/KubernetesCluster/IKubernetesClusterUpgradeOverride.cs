using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterUpgradeOverride), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterUpgradeOverride")]
    public interface IKubernetesClusterUpgradeOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#force_upgrade_enabled KubernetesCluster#force_upgrade_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forceUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ForceUpgradeEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#effective_until KubernetesCluster#effective_until}.</summary>
        [JsiiProperty(name: "effectiveUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EffectiveUntil
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterUpgradeOverride), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterUpgradeOverride")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterUpgradeOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#force_upgrade_enabled KubernetesCluster#force_upgrade_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "forceUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ForceUpgradeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#effective_until KubernetesCluster#effective_until}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EffectiveUntil
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
