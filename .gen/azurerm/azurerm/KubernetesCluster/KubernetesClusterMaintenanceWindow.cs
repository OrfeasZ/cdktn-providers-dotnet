using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow")]
    public class KubernetesClusterMaintenanceWindow : azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow
    {
        private object? _allowed;

        /// <summary>allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#allowed KubernetesCluster#allowed}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Allowed
        {
            get => _allowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowed = value;
            }
        }

        private object? _notAllowed;

        /// <summary>not_allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#not_allowed KubernetesCluster#not_allowed}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notAllowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotAllowed
        {
            get => _notAllowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notAllowed = value;
            }
        }
    }
}
