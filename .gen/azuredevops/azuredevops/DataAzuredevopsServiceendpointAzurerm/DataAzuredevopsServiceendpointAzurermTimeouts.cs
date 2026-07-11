using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointAzurerm
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurermTimeouts")]
    public class DataAzuredevopsServiceendpointAzurermTimeouts : azuredevops.DataAzuredevopsServiceendpointAzurerm.IDataAzuredevopsServiceendpointAzurermTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_azurerm#read DataAzuredevopsServiceendpointAzurerm#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
