using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationConfig), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationConfig")]
    public interface IEmrserverlessApplicationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#name EmrserverlessApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#release_label EmrserverlessApplication#release_label}.</summary>
        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        string ReleaseLabel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#type EmrserverlessApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#architecture EmrserverlessApplication#architecture}.</summary>
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Architecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_start_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#auto_start_configuration EmrserverlessApplication#auto_start_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoStartConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration? AutoStartConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_stop_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#auto_stop_configuration EmrserverlessApplication#auto_stop_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoStopConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration? AutoStopConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#id EmrserverlessApplication#id}.</summary>
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

        /// <summary>image_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#image_configuration EmrserverlessApplication#image_configuration}
        /// </remarks>
        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration? ImageConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>initial_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#initial_capacity EmrserverlessApplication#initial_capacity}
        /// </remarks>
        [JsiiProperty(name: "initialCapacity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitialCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>interactive_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#interactive_configuration EmrserverlessApplication#interactive_configuration}
        /// </remarks>
        [JsiiProperty(name: "interactiveConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration? InteractiveConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_level_cost_allocation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#job_level_cost_allocation_configuration EmrserverlessApplication#job_level_cost_allocation_configuration}
        /// </remarks>
        [JsiiProperty(name: "jobLevelCostAllocationConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationJobLevelCostAllocationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationJobLevelCostAllocationConfiguration? JobLevelCostAllocationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>maximum_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#maximum_capacity EmrserverlessApplication#maximum_capacity}
        /// </remarks>
        [JsiiProperty(name: "maximumCapacity", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity? MaximumCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#monitoring_configuration EmrserverlessApplication#monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration? MonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#network_configuration EmrserverlessApplication#network_configuration}
        /// </remarks>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration? NetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#region EmrserverlessApplication#region}
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

        /// <summary>runtime_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#runtime_configuration EmrserverlessApplication#runtime_configuration}
        /// </remarks>
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationRuntimeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuntimeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#scheduler_configuration EmrserverlessApplication#scheduler_configuration}
        /// </remarks>
        [JsiiProperty(name: "schedulerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration? SchedulerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#tags EmrserverlessApplication#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#tags_all EmrserverlessApplication#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationConfig), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#name EmrserverlessApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#release_label EmrserverlessApplication#release_label}.</summary>
            [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
            public string ReleaseLabel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#type EmrserverlessApplication#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#architecture EmrserverlessApplication#architecture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Architecture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>auto_start_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#auto_start_configuration EmrserverlessApplication#auto_start_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoStartConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration? AutoStartConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration?>();
            }

            /// <summary>auto_stop_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#auto_stop_configuration EmrserverlessApplication#auto_stop_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoStopConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration? AutoStopConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#id EmrserverlessApplication#id}.</summary>
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

            /// <summary>image_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#image_configuration EmrserverlessApplication#image_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration? ImageConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration?>();
            }

            /// <summary>initial_capacity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#initial_capacity EmrserverlessApplication#initial_capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialCapacity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitialCapacity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>interactive_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#interactive_configuration EmrserverlessApplication#interactive_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interactiveConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration? InteractiveConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration?>();
            }

            /// <summary>job_level_cost_allocation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#job_level_cost_allocation_configuration EmrserverlessApplication#job_level_cost_allocation_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobLevelCostAllocationConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationJobLevelCostAllocationConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationJobLevelCostAllocationConfiguration? JobLevelCostAllocationConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationJobLevelCostAllocationConfiguration?>();
            }

            /// <summary>maximum_capacity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#maximum_capacity EmrserverlessApplication#maximum_capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumCapacity", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity? MaximumCapacity
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity?>();
            }

            /// <summary>monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#monitoring_configuration EmrserverlessApplication#monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration? MonitoringConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration?>();
            }

            /// <summary>network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#network_configuration EmrserverlessApplication#network_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration? NetworkConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#region EmrserverlessApplication#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>runtime_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#runtime_configuration EmrserverlessApplication#runtime_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationRuntimeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuntimeConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scheduler_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#scheduler_configuration EmrserverlessApplication#scheduler_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedulerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration? SchedulerConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#tags EmrserverlessApplication#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#tags_all EmrserverlessApplication#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
