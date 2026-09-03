using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchApplication
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBatchApplication.DataAzurermBatchApplicationTimeouts")]
    public class DataAzurermBatchApplicationTimeouts : azurerm.DataAzurermBatchApplication.IDataAzurermBatchApplicationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/batch_application#read DataAzurermBatchApplication#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
