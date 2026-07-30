using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterOmsAgent")]
    public class KubernetesClusterOmsAgent : azurerm.KubernetesCluster.IKubernetesClusterOmsAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster#log_analytics_workspace_id KubernetesCluster#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogAnalyticsWorkspaceId
        {
            get;
            set;
        }

        private object? _msiAuthForMonitoringEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster#msi_auth_for_monitoring_enabled KubernetesCluster#msi_auth_for_monitoring_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "msiAuthForMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MsiAuthForMonitoringEnabled
        {
            get => _msiAuthForMonitoringEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _msiAuthForMonitoringEnabled = value;
            }
        }
    }
}
