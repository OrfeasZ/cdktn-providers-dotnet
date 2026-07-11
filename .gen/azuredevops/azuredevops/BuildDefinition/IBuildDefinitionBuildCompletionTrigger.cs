using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionBuildCompletionTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionBuildCompletionTrigger")]
    public interface IBuildDefinitionBuildCompletionTrigger
    {
        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionBuildCompletionTriggerBranchFilter\"},\"kind\":\"array\"}}]}}")]
        object BranchFilter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#build_definition_id BuildDefinition#build_definition_id}.</summary>
        [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
        double BuildDefinitionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionBuildCompletionTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionBuildCompletionTrigger")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>branch_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionBuildCompletionTriggerBranchFilter\"},\"kind\":\"array\"}}]}}")]
            public object BranchFilter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#build_definition_id BuildDefinition#build_definition_id}.</summary>
            [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
            public double BuildDefinitionId
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
