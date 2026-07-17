using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsArea
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsArea.DataAzuredevopsAreaTimeouts")]
    public class DataAzuredevopsAreaTimeouts : azuredevops.DataAzuredevopsArea.IDataAzuredevopsAreaTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/area#read DataAzuredevopsArea#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
