using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointGithub
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointGithub.DataAzuredevopsServiceendpointGithubTimeouts")]
    public class DataAzuredevopsServiceendpointGithubTimeouts : azuredevops.DataAzuredevopsServiceendpointGithub.IDataAzuredevopsServiceendpointGithubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_github#read DataAzuredevopsServiceendpointGithub#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
