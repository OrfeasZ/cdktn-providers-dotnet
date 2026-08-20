using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesAutomaticClusterHostedSystem), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem")]
    public interface IKubernetesAutomaticClusterHostedSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#node_subnet_id KubernetesAutomaticCluster#node_subnet_id}.</summary>
        [JsiiProperty(name: "nodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string NodeSubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#system_node_subnet_id KubernetesAutomaticCluster#system_node_subnet_id}.</summary>
        [JsiiProperty(name: "systemNodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SystemNodeSubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesAutomaticClusterHostedSystem), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#node_subnet_id KubernetesAutomaticCluster#node_subnet_id}.</summary>
            [JsiiProperty(name: "nodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#system_node_subnet_id KubernetesAutomaticCluster#system_node_subnet_id}.</summary>
            [JsiiProperty(name: "systemNodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SystemNodeSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
