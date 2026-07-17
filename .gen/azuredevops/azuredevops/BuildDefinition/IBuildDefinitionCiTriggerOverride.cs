using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionCiTriggerOverride), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride")]
    public interface IBuildDefinitionCiTriggerOverride
    {
        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverrideBranchFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}")]
        object BranchFilter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#batch BuildDefinition#batch}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "batch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Batch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#max_concurrent_builds_per_branch BuildDefinition#max_concurrent_builds_per_branch}.</summary>
        [JsiiProperty(name: "maxConcurrentBuildsPerBranch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentBuildsPerBranch
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverridePathFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PathFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#polling_interval BuildDefinition#polling_interval}.</summary>
        [JsiiProperty(name: "pollingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PollingInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionCiTriggerOverride), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>branch_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverrideBranchFilter" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}")]
            public object BranchFilter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#batch BuildDefinition#batch}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Batch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#max_concurrent_builds_per_branch BuildDefinition#max_concurrent_builds_per_branch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentBuildsPerBranch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentBuildsPerBranch
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>path_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverridePathFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PathFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#polling_interval BuildDefinition#polling_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pollingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PollingInterval
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
