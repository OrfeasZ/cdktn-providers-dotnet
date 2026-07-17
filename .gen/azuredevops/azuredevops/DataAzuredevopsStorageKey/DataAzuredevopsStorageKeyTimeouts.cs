using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsStorageKey
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsStorageKey.DataAzuredevopsStorageKeyTimeouts")]
    public class DataAzuredevopsStorageKeyTimeouts : azuredevops.DataAzuredevopsStorageKey.IDataAzuredevopsStorageKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/storage_key#read DataAzuredevopsStorageKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
