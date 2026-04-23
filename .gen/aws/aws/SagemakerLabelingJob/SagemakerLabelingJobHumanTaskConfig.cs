using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfig")]
    public class SagemakerLabelingJobHumanTaskConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#number_of_human_workers_per_data_object SagemakerLabelingJob#number_of_human_workers_per_data_object}.</summary>
        [JsiiProperty(name: "numberOfHumanWorkersPerDataObject", typeJson: "{\"primitive\":\"number\"}")]
        public double NumberOfHumanWorkersPerDataObject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_description SagemakerLabelingJob#task_description}.</summary>
        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_time_limit_in_seconds SagemakerLabelingJob#task_time_limit_in_seconds}.</summary>
        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double TaskTimeLimitInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_title SagemakerLabelingJob#task_title}.</summary>
        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskTitle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#workteam_arn SagemakerLabelingJob#workteam_arn}.</summary>
        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkteamArn
        {
            get;
            set;
        }

        private object? _annotationConsolidationConfig;

        /// <summary>annotation_consolidation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_config SagemakerLabelingJob#annotation_consolidation_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "annotationConsolidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AnnotationConsolidationConfig
        {
            get => _annotationConsolidationConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _annotationConsolidationConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_concurrent_task_count SagemakerLabelingJob#max_concurrent_task_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentTaskCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#pre_human_task_lambda_arn SagemakerLabelingJob#pre_human_task_lambda_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preHumanTaskLambdaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreHumanTaskLambdaArn
        {
            get;
            set;
        }

        private object? _publicWorkforceTaskPrice;

        /// <summary>public_workforce_task_price block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#public_workforce_task_price SagemakerLabelingJob#public_workforce_task_price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PublicWorkforceTaskPrice
        {
            get => _publicWorkforceTaskPrice;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publicWorkforceTaskPrice = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_availability_lifetime_in_seconds SagemakerLabelingJob#task_availability_lifetime_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TaskAvailabilityLifetimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_keywords SagemakerLabelingJob#task_keywords}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TaskKeywords
        {
            get;
            set;
        }

        private object? _uiConfig;

        /// <summary>ui_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#ui_config SagemakerLabelingJob#ui_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uiConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UiConfig
        {
            get => _uiConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uiConfig = value;
            }
        }
    }
}
