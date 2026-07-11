using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    [JsiiInterface(nativeType: typeof(ISynapseSparkPoolConfig), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolConfig")]
    public interface ISynapseSparkPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#name SynapseSparkPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_size SynapseSparkPool#node_size}.</summary>
        [JsiiProperty(name: "nodeSize", typeJson: "{\"primitive\":\"string\"}")]
        string NodeSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_size_family SynapseSparkPool#node_size_family}.</summary>
        [JsiiProperty(name: "nodeSizeFamily", typeJson: "{\"primitive\":\"string\"}")]
        string NodeSizeFamily
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_version SynapseSparkPool#spark_version}.</summary>
        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SparkVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#synapse_workspace_id SynapseSparkPool#synapse_workspace_id}.</summary>
        [JsiiProperty(name: "synapseWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string SynapseWorkspaceId
        {
            get;
        }

        /// <summary>auto_pause block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#auto_pause SynapseSparkPool#auto_pause}
        /// </remarks>
        [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoPause\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause? AutoPause
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#auto_scale SynapseSparkPool#auto_scale}
        /// </remarks>
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale? AutoScale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#cache_size SynapseSparkPool#cache_size}.</summary>
        [JsiiProperty(name: "cacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#compute_isolation_enabled SynapseSparkPool#compute_isolation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComputeIsolationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#dynamic_executor_allocation_enabled SynapseSparkPool#dynamic_executor_allocation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "dynamicExecutorAllocationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DynamicExecutorAllocationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#id SynapseSparkPool#id}.</summary>
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

        /// <summary>library_requirement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#library_requirement SynapseSparkPool#library_requirement}
        /// </remarks>
        [JsiiProperty(name: "libraryRequirement", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement? LibraryRequirement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#max_executors SynapseSparkPool#max_executors}.</summary>
        [JsiiProperty(name: "maxExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxExecutors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#min_executors SynapseSparkPool#min_executors}.</summary>
        [JsiiProperty(name: "minExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinExecutors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_count SynapseSparkPool#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#session_level_packages_enabled SynapseSparkPool#session_level_packages_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sessionLevelPackagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SessionLevelPackagesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>spark_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_config SynapseSparkPool#spark_config}
        /// </remarks>
        [JsiiProperty(name: "sparkConfig", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolSparkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig? SparkConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_events_folder SynapseSparkPool#spark_events_folder}.</summary>
        [JsiiProperty(name: "sparkEventsFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SparkEventsFolder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_log_folder SynapseSparkPool#spark_log_folder}.</summary>
        [JsiiProperty(name: "sparkLogFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SparkLogFolder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#tags SynapseSparkPool#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#timeouts SynapseSparkPool#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSparkPool.ISynapseSparkPoolTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSparkPoolConfig), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSparkPool.ISynapseSparkPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#name SynapseSparkPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_size SynapseSparkPool#node_size}.</summary>
            [JsiiProperty(name: "nodeSize", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeSize
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_size_family SynapseSparkPool#node_size_family}.</summary>
            [JsiiProperty(name: "nodeSizeFamily", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeSizeFamily
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_version SynapseSparkPool#spark_version}.</summary>
            [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SparkVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#synapse_workspace_id SynapseSparkPool#synapse_workspace_id}.</summary>
            [JsiiProperty(name: "synapseWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SynapseWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auto_pause block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#auto_pause SynapseSparkPool#auto_pause}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoPause\"}", isOptional: true)]
            public azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause? AutoPause
            {
                get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause?>();
            }

            /// <summary>auto_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#auto_scale SynapseSparkPool#auto_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoScale\"}", isOptional: true)]
            public azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale? AutoScale
            {
                get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#cache_size SynapseSparkPool#cache_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#compute_isolation_enabled SynapseSparkPool#compute_isolation_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ComputeIsolationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#dynamic_executor_allocation_enabled SynapseSparkPool#dynamic_executor_allocation_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicExecutorAllocationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DynamicExecutorAllocationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#id SynapseSparkPool#id}.</summary>
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

            /// <summary>library_requirement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#library_requirement SynapseSparkPool#library_requirement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "libraryRequirement", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement\"}", isOptional: true)]
            public azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement? LibraryRequirement
            {
                get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#max_executors SynapseSparkPool#max_executors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxExecutors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#min_executors SynapseSparkPool#min_executors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinExecutors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#node_count SynapseSparkPool#node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#session_level_packages_enabled SynapseSparkPool#session_level_packages_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionLevelPackagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SessionLevelPackagesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spark_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_config SynapseSparkPool#spark_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sparkConfig", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolSparkConfig\"}", isOptional: true)]
            public azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig? SparkConfig
            {
                get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_events_folder SynapseSparkPool#spark_events_folder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sparkEventsFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SparkEventsFolder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#spark_log_folder SynapseSparkPool#spark_log_folder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sparkLogFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SparkLogFolder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#tags SynapseSparkPool#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/synapse_spark_pool#timeouts SynapseSparkPool#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolTimeouts\"}", isOptional: true)]
            public azurerm.SynapseSparkPool.ISynapseSparkPoolTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolTimeouts?>();
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
