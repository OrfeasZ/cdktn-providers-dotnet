using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Endpoint
{
    [JsiiInterface(nativeType: typeof(IEndpointConfig), fullyQualifiedName: "neon.endpoint.EndpointConfig")]
    public interface IEndpointConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Branch ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#branch_id Endpoint#branch_id}
        /// </remarks>
        [JsiiProperty(name: "branchId", typeJson: "{\"primitive\":\"string\"}")]
        string BranchId
        {
            get;
        }

        /// <summary>Project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#project_id Endpoint#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_max_cu Endpoint#autoscaling_limit_max_cu}.</summary>
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMaxCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_min_cu Endpoint#autoscaling_limit_min_cu}.</summary>
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMinCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#compute_provisioner Endpoint#compute_provisioner}
        /// </remarks>
        [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeProvisioner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#disabled Endpoint#disabled}
        /// </remarks>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pg_settings Endpoint#pg_settings}.</summary>
        [JsiiProperty(name: "pgSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? PgSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Activate connection pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_enabled Endpoint#pooler_enabled}
        /// </remarks>
        [JsiiProperty(name: "poolerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PoolerEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mode of connections pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_mode Endpoint#pooler_mode}
        /// </remarks>
        [JsiiProperty(name: "poolerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolerMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#region_id Endpoint#region_id}
        /// </remarks>
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Duration of inactivity in seconds after which the compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#suspend_timeout_seconds Endpoint#suspend_timeout_seconds}
        /// </remarks>
        [JsiiProperty(name: "suspendTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuspendTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Access type. **Note** that a single branch can have only one "read_write" endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#type Endpoint#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEndpointConfig), fullyQualifiedName: "neon.endpoint.EndpointConfig")]
        internal sealed class _Proxy : DeputyBase, neon.Endpoint.IEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Branch ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#branch_id Endpoint#branch_id}
            /// </remarks>
            [JsiiProperty(name: "branchId", typeJson: "{\"primitive\":\"string\"}")]
            public string BranchId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#project_id Endpoint#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_max_cu Endpoint#autoscaling_limit_max_cu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMaxCu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#autoscaling_limit_min_cu Endpoint#autoscaling_limit_min_cu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMinCu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#compute_provisioner Endpoint#compute_provisioner}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeProvisioner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Disable the endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#disabled Endpoint#disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pg_settings Endpoint#pg_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pgSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? PgSettings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Activate connection pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_enabled Endpoint#pooler_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PoolerEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Mode of connections pooling. See details: https://neon.tech/docs/connect/connection-pooling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#pooler_mode Endpoint#pooler_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolerMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#region_id Endpoint#region_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegionId
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Access type. **Note** that a single branch can have only one "read_write" endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/endpoint#type Endpoint#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
