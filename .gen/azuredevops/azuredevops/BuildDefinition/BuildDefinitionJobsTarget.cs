using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionJobsTarget")]
    public class BuildDefinitionJobsTarget : azuredevops.BuildDefinition.IBuildDefinitionJobsTarget
    {
        /// <summary>execution_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#execution_options BuildDefinition#execution_options}
        /// </remarks>
        [JsiiProperty(name: "executionOptions", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptions\"}")]
        public azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions ExecutionOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#type BuildDefinition#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#demands BuildDefinition#demands}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "demands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Demands
        {
            get;
            set;
        }
    }
}
