using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails")]
    public class DatasciencePipelineStepDetailsStepDataflowConfigurationDetails : oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#configuration DatasciencePipeline#configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape DatasciencePipeline#driver_shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DriverShape
        {
            get;
            set;
        }

        /// <summary>driver_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape_config_details DatasciencePipeline#driver_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape DatasciencePipeline#executor_shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutorShape
        {
            get;
            set;
        }

        /// <summary>executor_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape_config_details DatasciencePipeline#executor_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#logs_bucket_uri DatasciencePipeline#logs_bucket_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogsBucketUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#num_executors DatasciencePipeline#num_executors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumExecutors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#warehouse_bucket_uri DatasciencePipeline#warehouse_bucket_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarehouseBucketUri
        {
            get;
            set;
        }
    }
}
