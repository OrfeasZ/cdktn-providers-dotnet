using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterOmsAgent), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterOmsAgent")]
    public interface IKubernetesClusterOmsAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#log_analytics_workspace_id KubernetesCluster#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string LogAnalyticsWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#msi_auth_for_monitoring_enabled KubernetesCluster#msi_auth_for_monitoring_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "msiAuthForMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MsiAuthForMonitoringEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#retina_flow_logs_enabled KubernetesCluster#retina_flow_logs_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "retinaFlowLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RetinaFlowLogsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterOmsAgent), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterOmsAgent")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterOmsAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#log_analytics_workspace_id KubernetesCluster#log_analytics_workspace_id}.</summary>
            [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogAnalyticsWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#msi_auth_for_monitoring_enabled KubernetesCluster#msi_auth_for_monitoring_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msiAuthForMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MsiAuthForMonitoringEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#retina_flow_logs_enabled KubernetesCluster#retina_flow_logs_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retinaFlowLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RetinaFlowLogsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
