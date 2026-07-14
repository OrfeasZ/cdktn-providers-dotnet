using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterNodePoolUpgradeSettings), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolUpgradeSettings")]
    public interface IKubernetesClusterNodePoolUpgradeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#drain_timeout_in_minutes KubernetesClusterNodePool#drain_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_surge KubernetesClusterNodePool#max_surge}.</summary>
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxSurge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_unavailable KubernetesClusterNodePool#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#node_soak_duration_in_minutes KubernetesClusterNodePool#node_soak_duration_in_minutes}.</summary>
        [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeSoakDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#undrainable_node_behavior KubernetesClusterNodePool#undrainable_node_behavior}.</summary>
        [JsiiProperty(name: "undrainableNodeBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UndrainableNodeBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterNodePoolUpgradeSettings), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolUpgradeSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolUpgradeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#drain_timeout_in_minutes KubernetesClusterNodePool#drain_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DrainTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_surge KubernetesClusterNodePool#max_surge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxSurge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_unavailable KubernetesClusterNodePool#max_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxUnavailable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#node_soak_duration_in_minutes KubernetesClusterNodePool#node_soak_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeSoakDurationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#undrainable_node_behavior KubernetesClusterNodePool#undrainable_node_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "undrainableNodeBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UndrainableNodeBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
