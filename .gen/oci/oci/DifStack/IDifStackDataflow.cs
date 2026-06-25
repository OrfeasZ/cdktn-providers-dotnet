using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackDataflow), fullyQualifiedName: "oci.difStack.DifStackDataflow")]
    public interface IDifStackDataflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#driver_shape DifStack#driver_shape}.</summary>
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        string DriverShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#executor_shape DifStack#executor_shape}.</summary>
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutorShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#log_bucket_instance_id DifStack#log_bucket_instance_id}.</summary>
        [JsiiProperty(name: "logBucketInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string LogBucketInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#num_executors DifStack#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        double NumExecutors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#spark_version DifStack#spark_version}.</summary>
        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SparkVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#archive_uri DifStack#archive_uri}.</summary>
        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchiveUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>connections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#connections DifStack#connections}
        /// </remarks>
        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DifStack.IDifStackDataflowConnections? Connections
        {
            get
            {
                return null;
            }
        }

        /// <summary>driver_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#driver_shape_config DifStack#driver_shape_config}
        /// </remarks>
        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DifStack.IDifStackDataflowDriverShapeConfig? DriverShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#execute DifStack#execute}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#executor_shape_config DifStack#executor_shape_config}
        /// </remarks>
        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DifStack.IDifStackDataflowExecutorShapeConfig? ExecutorShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#private_endpoint_id DifStack#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#warehouse_bucket_instance_id DifStack#warehouse_bucket_instance_id}.</summary>
        [JsiiProperty(name: "warehouseBucketInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseBucketInstanceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackDataflow), fullyQualifiedName: "oci.difStack.DifStackDataflow")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackDataflow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#driver_shape DifStack#driver_shape}.</summary>
            [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
            public string DriverShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#executor_shape DifStack#executor_shape}.</summary>
            [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutorShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#log_bucket_instance_id DifStack#log_bucket_instance_id}.</summary>
            [JsiiProperty(name: "logBucketInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogBucketInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#num_executors DifStack#num_executors}.</summary>
            [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
            public double NumExecutors
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#spark_version DifStack#spark_version}.</summary>
            [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SparkVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#archive_uri DifStack#archive_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchiveUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connections block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#connections DifStack#connections}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}", isOptional: true)]
            public oci.DifStack.IDifStackDataflowConnections? Connections
            {
                get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnections?>();
            }

            /// <summary>driver_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#driver_shape_config DifStack#driver_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfig\"}", isOptional: true)]
            public oci.DifStack.IDifStackDataflowDriverShapeConfig? DriverShapeConfig
            {
                get => GetInstanceProperty<oci.DifStack.IDifStackDataflowDriverShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#execute DifStack#execute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Execute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>executor_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#executor_shape_config DifStack#executor_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}", isOptional: true)]
            public oci.DifStack.IDifStackDataflowExecutorShapeConfig? ExecutorShapeConfig
            {
                get => GetInstanceProperty<oci.DifStack.IDifStackDataflowExecutorShapeConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#private_endpoint_id DifStack#private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#warehouse_bucket_instance_id DifStack#warehouse_bucket_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warehouseBucketInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarehouseBucketInstanceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
