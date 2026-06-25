using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackDataflow")]
    public class DifStackDataflow : oci.DifStack.IDifStackDataflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#driver_shape DifStack#driver_shape}.</summary>
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public string DriverShape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#executor_shape DifStack#executor_shape}.</summary>
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutorShape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#log_bucket_instance_id DifStack#log_bucket_instance_id}.</summary>
        [JsiiProperty(name: "logBucketInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogBucketInstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#num_executors DifStack#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public double NumExecutors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#spark_version DifStack#spark_version}.</summary>
        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SparkVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#archive_uri DifStack#archive_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArchiveUri
        {
            get;
            set;
        }

        /// <summary>connections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#connections DifStack#connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}", isOptional: true)]
        public oci.DifStack.IDifStackDataflowConnections? Connections
        {
            get;
            set;
        }

        /// <summary>driver_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#driver_shape_config DifStack#driver_shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfig\"}", isOptional: true)]
        public oci.DifStack.IDifStackDataflowDriverShapeConfig? DriverShapeConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#execute DifStack#execute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Execute
        {
            get;
            set;
        }

        /// <summary>executor_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#executor_shape_config DifStack#executor_shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}", isOptional: true)]
        public oci.DifStack.IDifStackDataflowExecutorShapeConfig? ExecutorShapeConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#private_endpoint_id DifStack#private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#warehouse_bucket_instance_id DifStack#warehouse_bucket_instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warehouseBucketInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarehouseBucketInstanceId
        {
            get;
            set;
        }
    }
}
