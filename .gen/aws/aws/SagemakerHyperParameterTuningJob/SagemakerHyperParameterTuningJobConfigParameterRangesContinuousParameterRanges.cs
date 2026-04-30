using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges")]
    public class SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_value SagemakerHyperParameterTuningJob#max_value}.</summary>
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}")]
        public string MaxValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_value SagemakerHyperParameterTuningJob#min_value}.</summary>
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}")]
        public string MinValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#name SagemakerHyperParameterTuningJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#scaling_type SagemakerHyperParameterTuningJob#scaling_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScalingType
        {
            get;
            set;
        }
    }
}
