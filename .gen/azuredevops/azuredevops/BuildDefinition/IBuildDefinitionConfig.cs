using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionConfig), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionConfig")]
    public interface IBuildDefinitionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#project_id BuildDefinition#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#repository BuildDefinition#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}")]
        azuredevops.BuildDefinition.IBuildDefinitionRepository Repository
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#agent_pool_name BuildDefinition#agent_pool_name}.</summary>
        [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#agent_specification BuildDefinition#agent_specification}.</summary>
        [JsiiProperty(name: "agentSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>build_completion_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#build_completion_trigger BuildDefinition#build_completion_trigger}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTrigger" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "buildCompletionTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionBuildCompletionTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuildCompletionTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>ci_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#ci_trigger BuildDefinition#ci_trigger}
        /// </remarks>
        [JsiiProperty(name: "ciTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? CiTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#features BuildDefinition#features}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionFeatures" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#id BuildDefinition#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_authorization_scope BuildDefinition#job_authorization_scope}.</summary>
        [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobAuthorizationScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>jobs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#jobs BuildDefinition#jobs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionJobs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "jobs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Jobs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#path BuildDefinition#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>pull_request_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#pull_request_trigger BuildDefinition#pull_request_trigger}
        /// </remarks>
        [JsiiProperty(name: "pullRequestTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? PullRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#queue_status BuildDefinition#queue_status}.</summary>
        [JsiiProperty(name: "queueStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#schedules BuildDefinition#schedules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionSchedules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schedules
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#timeouts BuildDefinition#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#variable BuildDefinition#variable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionVariable" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "variable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Variable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#variable_groups BuildDefinition#variable_groups}.</summary>
        [JsiiProperty(name: "variableGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? VariableGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionConfig), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#project_id BuildDefinition#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#repository BuildDefinition#repository}
            /// </remarks>
            [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}")]
            public azuredevops.BuildDefinition.IBuildDefinitionRepository Repository
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionRepository>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#agent_pool_name BuildDefinition#agent_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#agent_specification BuildDefinition#agent_specification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentSpecification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>build_completion_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#build_completion_trigger BuildDefinition#build_completion_trigger}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionBuildCompletionTrigger" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCompletionTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionBuildCompletionTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BuildCompletionTrigger
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ci_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#ci_trigger BuildDefinition#ci_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ciTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? CiTrigger
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTrigger?>();
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#features BuildDefinition#features}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionFeatures" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#id BuildDefinition#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_authorization_scope BuildDefinition#job_authorization_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobAuthorizationScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>jobs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#jobs BuildDefinition#jobs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionJobs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Jobs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#path BuildDefinition#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pull_request_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#pull_request_trigger BuildDefinition#pull_request_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequestTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? PullRequestTrigger
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#queue_status BuildDefinition#queue_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queueStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schedules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#schedules BuildDefinition#schedules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionSchedules" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schedules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#timeouts BuildDefinition#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionTimeouts\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionTimeouts?>();
            }

            /// <summary>variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#variable BuildDefinition#variable}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionVariable" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "variable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Variable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#variable_groups BuildDefinition#variable_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "variableGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? VariableGroups
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
