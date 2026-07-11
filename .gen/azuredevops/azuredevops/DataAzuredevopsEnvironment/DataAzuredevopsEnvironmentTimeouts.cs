using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsEnvironment
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsEnvironment.DataAzuredevopsEnvironmentTimeouts")]
    public class DataAzuredevopsEnvironmentTimeouts : azuredevops.DataAzuredevopsEnvironment.IDataAzuredevopsEnvironmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/environment#read DataAzuredevopsEnvironment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
