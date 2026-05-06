using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails")]
    public interface IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#configuration DatasciencePipelineRun#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape DatasciencePipelineRun#driver_shape}.</summary>
        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DriverShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>driver_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape_config_details DatasciencePipelineRun#driver_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape DatasciencePipelineRun#executor_shape}.</summary>
        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutorShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>executor_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape_config_details DatasciencePipelineRun#executor_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#logs_bucket_uri DatasciencePipelineRun#logs_bucket_uri}.</summary>
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogsBucketUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#num_executors DatasciencePipelineRun#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumExecutors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#warehouse_bucket_uri DatasciencePipelineRun#warehouse_bucket_uri}.</summary>
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseBucketUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#configuration DatasciencePipelineRun#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Configuration
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape DatasciencePipelineRun#driver_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriverShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>driver_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#driver_shape_config_details DatasciencePipelineRun#driver_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape DatasciencePipelineRun#executor_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutorShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>executor_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#executor_shape_config_details DatasciencePipelineRun#executor_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#logs_bucket_uri DatasciencePipelineRun#logs_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogsBucketUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#num_executors DatasciencePipelineRun#num_executors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumExecutors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#warehouse_bucket_uri DatasciencePipelineRun#warehouse_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarehouseBucketUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
