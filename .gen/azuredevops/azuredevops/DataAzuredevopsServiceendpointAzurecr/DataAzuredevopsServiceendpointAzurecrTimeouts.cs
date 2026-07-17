using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointAzurecr
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointAzurecr.DataAzuredevopsServiceendpointAzurecrTimeouts")]
    public class DataAzuredevopsServiceendpointAzurecrTimeouts : azuredevops.DataAzuredevopsServiceendpointAzurecr.IDataAzuredevopsServiceendpointAzurecrTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_azurecr#read DataAzuredevopsServiceendpointAzurecr#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
