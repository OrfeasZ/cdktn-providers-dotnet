using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput : aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#endpoint_name SagemakerMonitoringSchedule#endpoint_name}.</summary>
        [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#local_path SagemakerMonitoringSchedule#local_path}.</summary>
        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#end_time_offset SagemakerMonitoringSchedule#end_time_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endTimeOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndTimeOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#exclude_features_attribute SagemakerMonitoringSchedule#exclude_features_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeFeaturesAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludeFeaturesAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#features_attribute SagemakerMonitoringSchedule#features_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featuresAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FeaturesAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#inference_attribute SagemakerMonitoringSchedule#inference_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#probability_attribute SagemakerMonitoringSchedule#probability_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probabilityAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProbabilityAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#probability_threshold_attribute SagemakerMonitoringSchedule#probability_threshold_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probabilityThresholdAttribute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProbabilityThresholdAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#s3_data_distribution_type SagemakerMonitoringSchedule#s3_data_distribution_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3DataDistributionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#s3_input_mode SagemakerMonitoringSchedule#s3_input_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3InputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3InputMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#start_time_offset SagemakerMonitoringSchedule#start_time_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startTimeOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartTimeOffset
        {
            get;
            set;
        }
    }
}
