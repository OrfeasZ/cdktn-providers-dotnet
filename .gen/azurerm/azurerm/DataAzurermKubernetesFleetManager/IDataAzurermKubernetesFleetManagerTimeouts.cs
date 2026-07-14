using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesFleetManager
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKubernetesFleetManagerTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesFleetManager.DataAzurermKubernetesFleetManagerTimeouts")]
    public interface IDataAzurermKubernetesFleetManagerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/kubernetes_fleet_manager#read DataAzurermKubernetesFleetManager#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKubernetesFleetManagerTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesFleetManager.DataAzurermKubernetesFleetManagerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKubernetesFleetManager.IDataAzurermKubernetesFleetManagerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/kubernetes_fleet_manager#read DataAzurermKubernetesFleetManager#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
