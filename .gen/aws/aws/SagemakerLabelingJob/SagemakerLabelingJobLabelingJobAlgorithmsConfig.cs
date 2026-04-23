using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfig")]
    public class SagemakerLabelingJobLabelingJobAlgorithmsConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#labeling_job_algorithm_specification_arn SagemakerLabelingJob#labeling_job_algorithm_specification_arn}.</summary>
        [JsiiProperty(name: "labelingJobAlgorithmSpecificationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LabelingJobAlgorithmSpecificationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#initial_active_learning_model_arn SagemakerLabelingJob#initial_active_learning_model_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialActiveLearningModelArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialActiveLearningModelArn
        {
            get;
            set;
        }

        private object? _labelingJobResourceConfig;

        /// <summary>labeling_job_resource_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#labeling_job_resource_config SagemakerLabelingJob#labeling_job_resource_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelingJobResourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LabelingJobResourceConfig
        {
            get => _labelingJobResourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _labelingJobResourceConfig = value;
            }
        }
    }
}
