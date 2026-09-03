using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermGraphServicesAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermGraphServicesAccount.DataAzurermGraphServicesAccountTimeouts")]
    public class DataAzurermGraphServicesAccountTimeouts : azurerm.DataAzurermGraphServicesAccount.IDataAzurermGraphServicesAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/graph_services_account#read DataAzurermGraphServicesAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
