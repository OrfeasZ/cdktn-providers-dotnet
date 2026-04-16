using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmMaintenanceWindowTask
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskConfig")]
    public interface ISsmMaintenanceWindowTaskConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_arn SsmMaintenanceWindowTask#task_arn}.</summary>
        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
        string TaskArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_type SsmMaintenanceWindowTask#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        string TaskType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#window_id SsmMaintenanceWindowTask#window_id}.</summary>
        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
        string WindowId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#cutoff_behavior SsmMaintenanceWindowTask#cutoff_behavior}.</summary>
        [JsiiProperty(name: "cutoffBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CutoffBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#description SsmMaintenanceWindowTask#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#id SsmMaintenanceWindowTask#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#max_concurrency SsmMaintenanceWindowTask#max_concurrency}.</summary>
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxConcurrency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#max_errors SsmMaintenanceWindowTask#max_errors}.</summary>
        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxErrors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#priority SsmMaintenanceWindowTask#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#region SsmMaintenanceWindowTask#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#service_role_arn SsmMaintenanceWindowTask#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#targets SsmMaintenanceWindowTask#targets}
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Targets
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_invocation_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_invocation_parameters SsmMaintenanceWindowTask#task_invocation_parameters}
        /// </remarks>
        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters? TaskInvocationParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_arn SsmMaintenanceWindowTask#task_arn}.</summary>
            [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_type SsmMaintenanceWindowTask#task_type}.</summary>
            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#window_id SsmMaintenanceWindowTask#window_id}.</summary>
            [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
            public string WindowId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#cutoff_behavior SsmMaintenanceWindowTask#cutoff_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cutoffBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CutoffBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#description SsmMaintenanceWindowTask#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#id SsmMaintenanceWindowTask#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#max_concurrency SsmMaintenanceWindowTask#max_concurrency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxConcurrency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#max_errors SsmMaintenanceWindowTask#max_errors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxErrors
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#priority SsmMaintenanceWindowTask#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#region SsmMaintenanceWindowTask#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#service_role_arn SsmMaintenanceWindowTask#service_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#targets SsmMaintenanceWindowTask#targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Targets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>task_invocation_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ssm_maintenance_window_task#task_invocation_parameters SsmMaintenanceWindowTask#task_invocation_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
            public aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters? TaskInvocationParameters
            {
                get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters?>();
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
