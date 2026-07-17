using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionBuildCompletionTrigger")]
    public class BuildDefinitionBuildCompletionTrigger : azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTrigger
    {
        private object _branchFilter;

        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionBuildCompletionTriggerBranchFilter\"},\"kind\":\"array\"}}]}}")]
        public object BranchFilter
        {
            get => _branchFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTriggerBranchFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _branchFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#build_definition_id BuildDefinition#build_definition_id}.</summary>
        [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
        public double BuildDefinitionId
        {
            get;
            set;
        }
    }
}
