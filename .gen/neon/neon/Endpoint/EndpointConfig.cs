using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Endpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "neon.endpoint.EndpointConfig")]
    public class EndpointConfig : neon.Endpoint.IEndpointConfig
    {
        /// <summary>Branch ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#branch_id Endpoint#branch_id}
        /// </remarks>
        [JsiiProperty(name: "branchId", typeJson: "{\"primitive\":\"string\"}")]
        public string BranchId
        {
            get;
            set;
        }

        /// <summary>Project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#project_id Endpoint#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_max_cu Endpoint#autoscaling_limit_max_cu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMaxCu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_min_cu Endpoint#autoscaling_limit_min_cu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMinCu
        {
            get;
            set;
        }

        /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#compute_provisioner Endpoint#compute_provisioner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeProvisioner
        {
            get;
            set;
        }

        private object? _disabled;

        /// <summary>Disable the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#disabled Endpoint#disabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pg_settings Endpoint#pg_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pgSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? PgSettings
        {
            get;
            set;
        }

        private object? _poolerEnabled;

        /// <summary>Activate connection pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_enabled Endpoint#pooler_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PoolerEnabled
        {
            get => _poolerEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _poolerEnabled = value;
            }
        }

        /// <summary>Mode of connections pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_mode Endpoint#pooler_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolerMode
        {
            get;
            set;
        }

        /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#region_id Endpoint#region_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionId
        {
            get;
            set;
        }

        /// <summary>Duration of inactivity in seconds after which the compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#suspend_timeout_seconds Endpoint#suspend_timeout_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suspendTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuspendTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Access type. **Note** that a single branch can have only one "read_write" endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#type Endpoint#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
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
