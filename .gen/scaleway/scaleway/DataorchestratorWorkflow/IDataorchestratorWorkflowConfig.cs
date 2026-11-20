using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataorchestratorWorkflow
{
    [JsiiInterface(nativeType: typeof(IDataorchestratorWorkflowConfig), fullyQualifiedName: "scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowConfig")]
    public interface IDataorchestratorWorkflowConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Open Workflow Specification YAML for the current workflow version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#workflow_dsl DataorchestratorWorkflow#workflow_dsl}
        /// </remarks>
        [JsiiProperty(name: "workflowDsl", typeJson: "{\"primitive\":\"string\"}")]
        string WorkflowDsl
        {
            get;
        }

        /// <summary>Optional cron schedule for the workflow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#cron_schedule DataorchestratorWorkflow#cron_schedule}
        /// </remarks>
        [JsiiProperty(name: "cronSchedule", typeJson: "{\"fqn\":\"scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowCronSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowCronSchedule? CronSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the workflow definition. Omit the attribute to leave it empty; an empty string is not allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#description DataorchestratorWorkflow#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment variables of the workflow definition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#environment_variables DataorchestratorWorkflow#environment_variables}
        /// </remarks>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the workflow definition. If omitted, a random name is generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#name DataorchestratorWorkflow#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Project ID. Defaults to the provider project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#project_id DataorchestratorWorkflow#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region of the workflow. Only `fr-par` is currently supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#region DataorchestratorWorkflow#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the current workflow version. Omit the attribute to leave it empty; an empty string is not allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#version_description DataorchestratorWorkflow#version_description}
        /// </remarks>
        [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the current workflow version (3-50 chars: letters, digits, `-`, `_`). Defaults to `v1-0-0` on create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#version_name DataorchestratorWorkflow#version_name}
        /// </remarks>
        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataorchestratorWorkflowConfig), fullyQualifiedName: "scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Open Workflow Specification YAML for the current workflow version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#workflow_dsl DataorchestratorWorkflow#workflow_dsl}
            /// </remarks>
            [JsiiProperty(name: "workflowDsl", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkflowDsl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Optional cron schedule for the workflow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#cron_schedule DataorchestratorWorkflow#cron_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cronSchedule", typeJson: "{\"fqn\":\"scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowCronSchedule\"}", isOptional: true)]
            public scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowCronSchedule? CronSchedule
            {
                get => GetInstanceProperty<scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowCronSchedule?>();
            }

            /// <summary>Description of the workflow definition. Omit the attribute to leave it empty; an empty string is not allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#description DataorchestratorWorkflow#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Environment variables of the workflow definition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#environment_variables DataorchestratorWorkflow#environment_variables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Name of the workflow definition. If omitted, a random name is generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#name DataorchestratorWorkflow#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Project ID. Defaults to the provider project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#project_id DataorchestratorWorkflow#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region of the workflow. Only `fr-par` is currently supported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#region DataorchestratorWorkflow#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the current workflow version. Omit the attribute to leave it empty; an empty string is not allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#version_description DataorchestratorWorkflow#version_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the current workflow version (3-50 chars: letters, digits, `-`, `_`). Defaults to `v1-0-0` on create.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#version_name DataorchestratorWorkflow#version_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionName
            {
                get => GetInstanceProperty<string?>();
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
