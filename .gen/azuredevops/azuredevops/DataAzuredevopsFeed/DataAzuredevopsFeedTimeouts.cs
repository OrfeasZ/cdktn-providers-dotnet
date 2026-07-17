using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsFeed
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsFeed.DataAzuredevopsFeedTimeouts")]
    public class DataAzuredevopsFeedTimeouts : azuredevops.DataAzuredevopsFeed.IDataAzuredevopsFeedTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/feed#read DataAzuredevopsFeed#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
