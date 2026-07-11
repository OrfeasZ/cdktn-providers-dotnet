using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionJobsTarget), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobsTarget")]
    public interface IBuildDefinitionJobsTarget
    {
        /// <summary>execution_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#execution_options BuildDefinition#execution_options}
        /// </remarks>
        [JsiiProperty(name: "executionOptions", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptions\"}")]
        azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions ExecutionOptions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#type BuildDefinition#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#demands BuildDefinition#demands}.</summary>
        [JsiiProperty(name: "demands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Demands
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionJobsTarget), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobsTarget")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionJobsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>execution_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#execution_options BuildDefinition#execution_options}
            /// </remarks>
            [JsiiProperty(name: "executionOptions", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptions\"}")]
            public azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions ExecutionOptions
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#type BuildDefinition#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#demands BuildDefinition#demands}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "demands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Demands
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
