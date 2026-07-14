using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterUpgradeOverride")]
    public class KubernetesClusterUpgradeOverride : azurerm.KubernetesCluster.IKubernetesClusterUpgradeOverride
    {
        private object _forceUpgradeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#force_upgrade_enabled KubernetesCluster#force_upgrade_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forceUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object ForceUpgradeEnabled
        {
            get => _forceUpgradeEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forceUpgradeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#effective_until KubernetesCluster#effective_until}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "effectiveUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EffectiveUntil
        {
            get;
            set;
        }
    }
}
