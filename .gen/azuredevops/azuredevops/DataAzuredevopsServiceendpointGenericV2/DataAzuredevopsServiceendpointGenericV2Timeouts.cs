using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointGenericV2
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointGenericV2.DataAzuredevopsServiceendpointGenericV2Timeouts")]
    public class DataAzuredevopsServiceendpointGenericV2Timeouts : azuredevops.DataAzuredevopsServiceendpointGenericV2.IDataAzuredevopsServiceendpointGenericV2Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_generic_v2#read DataAzuredevopsServiceendpointGenericV2#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
