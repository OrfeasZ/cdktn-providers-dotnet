using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowApplication
{
    [JsiiInterface(nativeType: typeof(IDataflowApplicationConfig), fullyQualifiedName: "oci.dataflowApplication.DataflowApplicationConfig")]
    public interface IDataflowApplicationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#compartment_id DataflowApplication#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#display_name DataflowApplication#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#driver_shape DataflowApplication#driver_shape}.</summary>
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        string DriverShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#executor_shape DataflowApplication#executor_shape}.</summary>
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutorShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#language DataflowApplication#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        string Language
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#num_executors DataflowApplication#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        double NumExecutors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#spark_version DataflowApplication#spark_version}.</summary>
        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SparkVersion
        {
            get;
        }

        /// <summary>application_log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#application_log_config DataflowApplication#application_log_config}
        /// </remarks>
        [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationApplicationLogConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowApplication.IDataflowApplicationApplicationLogConfig? ApplicationLogConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#archive_uri DataflowApplication#archive_uri}.</summary>
        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchiveUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#arguments DataflowApplication#arguments}.</summary>
        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Arguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#class_name DataflowApplication#class_name}.</summary>
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClassName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#configuration DataflowApplication#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#defined_tags DataflowApplication#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#description DataflowApplication#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>driver_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#driver_shape_config DataflowApplication#driver_shape_config}
        /// </remarks>
        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationDriverShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowApplication.IDataflowApplicationDriverShapeConfig? DriverShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#execute DataflowApplication#execute}.</summary>
        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Execute
        {
            get
            {
                return null;
            }
        }

        /// <summary>executor_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#executor_shape_config DataflowApplication#executor_shape_config}
        /// </remarks>
        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationExecutorShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig? ExecutorShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#file_uri DataflowApplication#file_uri}.</summary>
        [JsiiProperty(name: "fileUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#freeform_tags DataflowApplication#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#id DataflowApplication#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#idle_timeout_in_minutes DataflowApplication#idle_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdleTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#logs_bucket_uri DataflowApplication#logs_bucket_uri}.</summary>
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogsBucketUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#max_duration_in_minutes DataflowApplication#max_duration_in_minutes}.</summary>
        [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#metastore_id DataflowApplication#metastore_id}.</summary>
        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetastoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#parameters DataflowApplication#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#pool_id DataflowApplication#pool_id}.</summary>
        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#private_endpoint_id DataflowApplication#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#terminate_runs_on_deletion DataflowApplication#terminate_runs_on_deletion}.</summary>
        [JsiiProperty(name: "terminateRunsOnDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TerminateRunsOnDeletion
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#timeouts DataflowApplication#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataflowApplication.IDataflowApplicationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#type DataflowApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#warehouse_bucket_uri DataflowApplication#warehouse_bucket_uri}.</summary>
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseBucketUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowApplicationConfig), fullyQualifiedName: "oci.dataflowApplication.DataflowApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowApplication.IDataflowApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#compartment_id DataflowApplication#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#display_name DataflowApplication#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#driver_shape DataflowApplication#driver_shape}.</summary>
            [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
            public string DriverShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#executor_shape DataflowApplication#executor_shape}.</summary>
            [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutorShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#language DataflowApplication#language}.</summary>
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
            public string Language
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#num_executors DataflowApplication#num_executors}.</summary>
            [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
            public double NumExecutors
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#spark_version DataflowApplication#spark_version}.</summary>
            [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SparkVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>application_log_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#application_log_config DataflowApplication#application_log_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationApplicationLogConfig\"}", isOptional: true)]
            public oci.DataflowApplication.IDataflowApplicationApplicationLogConfig? ApplicationLogConfig
            {
                get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationApplicationLogConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#archive_uri DataflowApplication#archive_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchiveUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#arguments DataflowApplication#arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Arguments
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#class_name DataflowApplication#class_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#configuration DataflowApplication#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Configuration
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#defined_tags DataflowApplication#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#description DataflowApplication#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>driver_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#driver_shape_config DataflowApplication#driver_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationDriverShapeConfig\"}", isOptional: true)]
            public oci.DataflowApplication.IDataflowApplicationDriverShapeConfig? DriverShapeConfig
            {
                get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationDriverShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#execute DataflowApplication#execute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Execute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>executor_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#executor_shape_config DataflowApplication#executor_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationExecutorShapeConfig\"}", isOptional: true)]
            public oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig? ExecutorShapeConfig
            {
                get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#file_uri DataflowApplication#file_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#freeform_tags DataflowApplication#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#id DataflowApplication#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#idle_timeout_in_minutes DataflowApplication#idle_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdleTimeoutInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#logs_bucket_uri DataflowApplication#logs_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogsBucketUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#max_duration_in_minutes DataflowApplication#max_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxDurationInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#metastore_id DataflowApplication#metastore_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetastoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#parameters DataflowApplication#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#pool_id DataflowApplication#pool_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#private_endpoint_id DataflowApplication#private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#terminate_runs_on_deletion DataflowApplication#terminate_runs_on_deletion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateRunsOnDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TerminateRunsOnDeletion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#timeouts DataflowApplication#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationTimeouts\"}", isOptional: true)]
            public oci.DataflowApplication.IDataflowApplicationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#type DataflowApplication#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#warehouse_bucket_uri DataflowApplication#warehouse_bucket_uri}.</summary>
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
