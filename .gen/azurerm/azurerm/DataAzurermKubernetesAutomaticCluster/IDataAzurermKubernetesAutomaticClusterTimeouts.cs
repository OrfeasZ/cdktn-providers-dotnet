using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKubernetesAutomaticClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeouts")]
    public interface IDataAzurermKubernetesAutomaticClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/kubernetes_automatic_cluster#read DataAzurermKubernetesAutomaticCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKubernetesAutomaticClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/kubernetes_automatic_cluster#read DataAzurermKubernetesAutomaticCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
