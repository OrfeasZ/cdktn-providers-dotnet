using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiByValue(fqn: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails")]
    public class DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails : oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#configuration DatasciencePipelineRun#configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape DatasciencePipelineRun#driver_shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DriverShape
        {
            get;
            set;
        }

        /// <summary>driver_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape_config_details DatasciencePipelineRun#driver_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape DatasciencePipelineRun#executor_shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutorShape
        {
            get;
            set;
        }

        /// <summary>executor_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape_config_details DatasciencePipelineRun#executor_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#logs_bucket_uri DatasciencePipelineRun#logs_bucket_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogsBucketUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#num_executors DatasciencePipelineRun#num_executors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumExecutors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#warehouse_bucket_uri DatasciencePipelineRun#warehouse_bucket_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarehouseBucketUri
        {
            get;
            set;
        }
    }
}
