using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStackHciStoragePath
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStackHciStoragePath.DataAzurermStackHciStoragePathTimeouts")]
    public class DataAzurermStackHciStoragePathTimeouts : azurerm.DataAzurermStackHciStoragePath.IDataAzurermStackHciStoragePathTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/stack_hci_storage_path#read DataAzurermStackHciStoragePath#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
