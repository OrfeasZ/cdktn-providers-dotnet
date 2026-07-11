using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsBuildDefinition
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionTimeouts")]
    public class DataAzuredevopsBuildDefinitionTimeouts : azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/build_definition#read DataAzuredevopsBuildDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
