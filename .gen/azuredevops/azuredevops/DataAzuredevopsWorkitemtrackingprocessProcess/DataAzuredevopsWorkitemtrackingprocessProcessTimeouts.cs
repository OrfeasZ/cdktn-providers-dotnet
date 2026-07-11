using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessProcess
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcess.DataAzuredevopsWorkitemtrackingprocessProcessTimeouts")]
    public class DataAzuredevopsWorkitemtrackingprocessProcessTimeouts : azuredevops.DataAzuredevopsWorkitemtrackingprocessProcess.IDataAzuredevopsWorkitemtrackingprocessProcessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/workitemtrackingprocess_process#read DataAzuredevopsWorkitemtrackingprocessProcess#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
