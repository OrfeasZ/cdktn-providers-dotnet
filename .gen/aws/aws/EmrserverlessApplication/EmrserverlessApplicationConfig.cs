using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationConfig")]
    public class EmrserverlessApplicationConfig : aws.EmrserverlessApplication.IEmrserverlessApplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#name EmrserverlessApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#release_label EmrserverlessApplication#release_label}.</summary>
        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        public string ReleaseLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#type EmrserverlessApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#architecture EmrserverlessApplication#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>auto_start_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#auto_start_configuration EmrserverlessApplication#auto_start_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoStartConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration? AutoStartConfiguration
        {
            get;
            set;
        }

        /// <summary>auto_stop_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#auto_stop_configuration EmrserverlessApplication#auto_stop_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoStopConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration? AutoStopConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#id EmrserverlessApplication#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>image_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#image_configuration EmrserverlessApplication#image_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration? ImageConfiguration
        {
            get;
            set;
        }

        private object? _initialCapacity;

        /// <summary>initial_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#initial_capacity EmrserverlessApplication#initial_capacity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialCapacity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InitialCapacity
        {
            get => _initialCapacity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _initialCapacity = value;
            }
        }

        /// <summary>interactive_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#interactive_configuration EmrserverlessApplication#interactive_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interactiveConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration? InteractiveConfiguration
        {
            get;
            set;
        }

        /// <summary>job_level_cost_allocation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#job_level_cost_allocation_configuration EmrserverlessApplication#job_level_cost_allocation_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobLevelCostAllocationConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationJobLevelCostAllocationConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationJobLevelCostAllocationConfiguration? JobLevelCostAllocationConfiguration
        {
            get;
            set;
        }

        /// <summary>maximum_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#maximum_capacity EmrserverlessApplication#maximum_capacity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumCapacity", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity? MaximumCapacity
        {
            get;
            set;
        }

        /// <summary>monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#monitoring_configuration EmrserverlessApplication#monitoring_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration? MonitoringConfiguration
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#network_configuration EmrserverlessApplication#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#region EmrserverlessApplication#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        private object? _runtimeConfiguration;

        /// <summary>runtime_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#runtime_configuration EmrserverlessApplication#runtime_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationRuntimeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RuntimeConfiguration
        {
            get => _runtimeConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EmrserverlessApplication.IEmrserverlessApplicationRuntimeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationRuntimeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _runtimeConfiguration = value;
            }
        }

        /// <summary>scheduler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#scheduler_configuration EmrserverlessApplication#scheduler_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration? SchedulerConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#tags EmrserverlessApplication#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#tags_all EmrserverlessApplication#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
