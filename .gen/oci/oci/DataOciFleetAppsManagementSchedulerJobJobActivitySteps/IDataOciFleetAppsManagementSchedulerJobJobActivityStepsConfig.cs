using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementSchedulerJobJobActivitySteps
{
    [JsiiInterface(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig")]
    public interface IDataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#job_activity_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#job_activity_id}.</summary>
        [JsiiProperty(name: "jobActivityId", typeJson: "{\"primitive\":\"string\"}")]
        string JobActivityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#scheduler_job_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#scheduler_job_id}.</summary>
        [JsiiProperty(name: "schedulerJobId", typeJson: "{\"primitive\":\"string\"}")]
        string SchedulerJobId
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#filter DataOciFleetAppsManagementSchedulerJobJobActivitySteps#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#resource_task_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#resource_task_id}.</summary>
        [JsiiProperty(name: "resourceTaskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTaskId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#sequence DataOciFleetAppsManagementSchedulerJobJobActivitySteps#sequence}.</summary>
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sequence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#step_name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StepName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#target_name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#target_name}.</summary>
        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciFleetAppsManagementSchedulerJobJobActivitySteps.IDataOciFleetAppsManagementSchedulerJobJobActivityStepsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#job_activity_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#job_activity_id}.</summary>
            [JsiiProperty(name: "jobActivityId", typeJson: "{\"primitive\":\"string\"}")]
            public string JobActivityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#scheduler_job_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#scheduler_job_id}.</summary>
            [JsiiProperty(name: "schedulerJobId", typeJson: "{\"primitive\":\"string\"}")]
            public string SchedulerJobId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#filter DataOciFleetAppsManagementSchedulerJobJobActivitySteps#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#resource_task_id DataOciFleetAppsManagementSchedulerJobJobActivitySteps#resource_task_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTaskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTaskId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#sequence DataOciFleetAppsManagementSchedulerJobJobActivitySteps#sequence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sequence
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#step_name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#step_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StepName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#target_name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#target_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
