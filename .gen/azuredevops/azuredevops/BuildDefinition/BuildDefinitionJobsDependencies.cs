using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionJobsDependencies")]
    public class BuildDefinitionJobsDependencies : azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#scope BuildDefinition#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public string Scope
        {
            get;
            set;
        }
    }
}
