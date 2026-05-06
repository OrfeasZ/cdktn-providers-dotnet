using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails")]
    public interface IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#configuration DatasciencePipeline#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape DatasciencePipeline#driver_shape}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape_config_details DatasciencePipeline#driver_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape DatasciencePipeline#executor_shape}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape_config_details DatasciencePipeline#executor_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#logs_bucket_uri DatasciencePipeline#logs_bucket_uri}.</summary>
        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogsBucketUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#num_executors DatasciencePipeline#num_executors}.</summary>
        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumExecutors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#warehouse_bucket_uri DatasciencePipeline#warehouse_bucket_uri}.</summary>
        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseBucketUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#configuration DatasciencePipeline#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Configuration
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape DatasciencePipeline#driver_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriverShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>driver_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#driver_shape_config_details DatasciencePipeline#driver_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails? DriverShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape DatasciencePipeline#executor_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutorShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>executor_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#executor_shape_config_details DatasciencePipeline#executor_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails? ExecutorShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#logs_bucket_uri DatasciencePipeline#logs_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogsBucketUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#num_executors DatasciencePipeline#num_executors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumExecutors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#warehouse_bucket_uri DatasciencePipeline#warehouse_bucket_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarehouseBucketUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
