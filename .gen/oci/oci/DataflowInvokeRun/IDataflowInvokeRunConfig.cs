using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowInvokeRun
{
    [JsiiInterface(nativeType: typeof(IDataflowInvokeRunConfig), fullyQualifiedName: "oci.dataflowInvokeRun.DataflowInvokeRunConfig")]
    public interface IDataflowInvokeRunConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#compartment_id DataflowInvokeRun#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#application_id DataflowInvokeRun#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>application_log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#application_log_config DataflowInvokeRun#application_log_config}
        /// </remarks>
        [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunApplicationLogConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowInvokeRun.IDataflowInvokeRunApplicationLogConfig? ApplicationLogConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#archive_uri DataflowInvokeRun#archive_uri}.</summary>
        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchiveUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#arguments DataflowInvokeRun#arguments}.</summary>
        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Arguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#asynchronous DataflowInvokeRun#asynchronous}.</summary>
        [JsiiProperty(name: "asynchronous", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Asynchronous
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#configuration DataflowInvokeRun#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#defined_tags DataflowInvokeRun#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#display_name DataflowInvokeRun#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#driver_shape DataflowInvokeRun#driver_shape}.</summary>
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DriverShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>driver_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#driver_shape_config DataflowInvokeRun#driver_shape_config}
        /// </remarks>
        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunDriverShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowInvokeRun.IDataflowInvokeRunDriverShapeConfig? DriverShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#execute DataflowInvokeRun#execute}.</summary>
        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Execute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#executor_shape DataflowInvokeRun#executor_shape}.</summary>
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutorShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>executor_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#executor_shape_config DataflowInvokeRun#executor_shape_config}
        /// </remarks>
        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunExecutorShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowInvokeRun.IDataflowInvokeRunExecutorShapeConfig? ExecutorShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#freeform_tags DataflowInvokeRun#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#id DataflowInvokeRun#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#idle_timeout_in_minutes DataflowInvokeRun#idle_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdleTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#logs_bucket_uri DataflowInvokeRun#logs_bucket_uri}.</summary>
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogsBucketUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#max_duration_in_minutes DataflowInvokeRun#max_duration_in_minutes}.</summary>
        [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#metastore_id DataflowInvokeRun#metastore_id}.</summary>
        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetastoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#num_executors DataflowInvokeRun#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumExecutors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#opc_parent_rpt_url DataflowInvokeRun#opc_parent_rpt_url}.</summary>
        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpcParentRptUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#parameters DataflowInvokeRun#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#pool_id DataflowInvokeRun#pool_id}.</summary>
        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#spark_version DataflowInvokeRun#spark_version}.</summary>
        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SparkVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#timeouts DataflowInvokeRun#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowInvokeRun.IDataflowInvokeRunTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#type DataflowInvokeRun#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#warehouse_bucket_uri DataflowInvokeRun#warehouse_bucket_uri}.</summary>
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseBucketUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowInvokeRunConfig), fullyQualifiedName: "oci.dataflowInvokeRun.DataflowInvokeRunConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowInvokeRun.IDataflowInvokeRunConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#compartment_id DataflowInvokeRun#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#application_id DataflowInvokeRun#application_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>application_log_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#application_log_config DataflowInvokeRun#application_log_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunApplicationLogConfig\"}", isOptional: true)]
            public oci.DataflowInvokeRun.IDataflowInvokeRunApplicationLogConfig? ApplicationLogConfig
            {
                get => GetInstanceProperty<oci.DataflowInvokeRun.IDataflowInvokeRunApplicationLogConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#archive_uri DataflowInvokeRun#archive_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchiveUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#arguments DataflowInvokeRun#arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Arguments
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#asynchronous DataflowInvokeRun#asynchronous}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "asynchronous", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Asynchronous
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#configuration DataflowInvokeRun#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Configuration
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#defined_tags DataflowInvokeRun#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#display_name DataflowInvokeRun#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#driver_shape DataflowInvokeRun#driver_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriverShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>driver_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#driver_shape_config DataflowInvokeRun#driver_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunDriverShapeConfig\"}", isOptional: true)]
            public oci.DataflowInvokeRun.IDataflowInvokeRunDriverShapeConfig? DriverShapeConfig
            {
                get => GetInstanceProperty<oci.DataflowInvokeRun.IDataflowInvokeRunDriverShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#execute DataflowInvokeRun#execute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Execute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#executor_shape DataflowInvokeRun#executor_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutorShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>executor_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#executor_shape_config DataflowInvokeRun#executor_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunExecutorShapeConfig\"}", isOptional: true)]
            public oci.DataflowInvokeRun.IDataflowInvokeRunExecutorShapeConfig? ExecutorShapeConfig
            {
                get => GetInstanceProperty<oci.DataflowInvokeRun.IDataflowInvokeRunExecutorShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#freeform_tags DataflowInvokeRun#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#id DataflowInvokeRun#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#idle_timeout_in_minutes DataflowInvokeRun#idle_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdleTimeoutInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#logs_bucket_uri DataflowInvokeRun#logs_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogsBucketUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#max_duration_in_minutes DataflowInvokeRun#max_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxDurationInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#metastore_id DataflowInvokeRun#metastore_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetastoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#num_executors DataflowInvokeRun#num_executors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumExecutors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#opc_parent_rpt_url DataflowInvokeRun#opc_parent_rpt_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpcParentRptUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#parameters DataflowInvokeRun#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#pool_id DataflowInvokeRun#pool_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#spark_version DataflowInvokeRun#spark_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SparkVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#timeouts DataflowInvokeRun#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowInvokeRun.DataflowInvokeRunTimeouts\"}", isOptional: true)]
            public oci.DataflowInvokeRun.IDataflowInvokeRunTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataflowInvokeRun.IDataflowInvokeRunTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#type DataflowInvokeRun#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#warehouse_bucket_uri DataflowInvokeRun#warehouse_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarehouseBucketUri
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
