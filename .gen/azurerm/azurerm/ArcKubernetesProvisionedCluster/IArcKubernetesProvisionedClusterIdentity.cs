using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesProvisionedCluster
{
    [JsiiInterface(nativeType: typeof(IArcKubernetesProvisionedClusterIdentity), fullyQualifiedName: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentity")]
    public interface IArcKubernetesProvisionedClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/arc_kubernetes_provisioned_cluster#type ArcKubernetesProvisionedCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcKubernetesProvisionedClusterIdentity), fullyQualifiedName: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/arc_kubernetes_provisioned_cluster#type ArcKubernetesProvisionedCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
