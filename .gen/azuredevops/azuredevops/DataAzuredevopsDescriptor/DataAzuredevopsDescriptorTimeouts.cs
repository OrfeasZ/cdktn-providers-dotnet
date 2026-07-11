using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsDescriptor
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsDescriptor.DataAzuredevopsDescriptorTimeouts")]
    public class DataAzuredevopsDescriptorTimeouts : azuredevops.DataAzuredevopsDescriptor.IDataAzuredevopsDescriptorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/descriptor#read DataAzuredevopsDescriptor#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
