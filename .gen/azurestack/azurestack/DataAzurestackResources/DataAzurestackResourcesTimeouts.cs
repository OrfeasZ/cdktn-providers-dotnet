using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackResources
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackResources.DataAzurestackResourcesTimeouts")]
    public class DataAzurestackResourcesTimeouts : azurestack.DataAzurestackResources.IDataAzurestackResourcesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/resources#read DataAzurestackResources#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
