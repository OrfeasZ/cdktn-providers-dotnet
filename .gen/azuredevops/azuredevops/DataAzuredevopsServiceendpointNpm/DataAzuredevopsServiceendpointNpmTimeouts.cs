using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointNpm
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointNpm.DataAzuredevopsServiceendpointNpmTimeouts")]
    public class DataAzuredevopsServiceendpointNpmTimeouts : azuredevops.DataAzuredevopsServiceendpointNpm.IDataAzuredevopsServiceendpointNpmTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_npm#read DataAzuredevopsServiceendpointNpm#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
