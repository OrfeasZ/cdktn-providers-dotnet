using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointDockerregistry
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointDockerregistry.DataAzuredevopsServiceendpointDockerregistryTimeouts")]
    public class DataAzuredevopsServiceendpointDockerregistryTimeouts : azuredevops.DataAzuredevopsServiceendpointDockerregistry.IDataAzuredevopsServiceendpointDockerregistryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_dockerregistry#read DataAzuredevopsServiceendpointDockerregistry#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
