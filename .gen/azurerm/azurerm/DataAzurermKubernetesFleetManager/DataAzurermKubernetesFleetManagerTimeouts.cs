using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesFleetManager
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKubernetesFleetManager.DataAzurermKubernetesFleetManagerTimeouts")]
    public class DataAzurermKubernetesFleetManagerTimeouts : azurerm.DataAzurermKubernetesFleetManager.IDataAzurermKubernetesFleetManagerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/kubernetes_fleet_manager#read DataAzurermKubernetesFleetManager#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
