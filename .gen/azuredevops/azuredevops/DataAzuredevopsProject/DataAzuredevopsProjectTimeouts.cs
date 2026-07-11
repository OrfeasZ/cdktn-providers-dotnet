using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsProject
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsProject.DataAzuredevopsProjectTimeouts")]
    public class DataAzuredevopsProjectTimeouts : azuredevops.DataAzuredevopsProject.IDataAzuredevopsProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/project#read DataAzuredevopsProject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
