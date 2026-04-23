using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfig")]
    public interface ISagemakerLabelingJobHumanTaskConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#number_of_human_workers_per_data_object SagemakerLabelingJob#number_of_human_workers_per_data_object}.</summary>
        [JsiiProperty(name: "numberOfHumanWorkersPerDataObject", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfHumanWorkersPerDataObject
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_description SagemakerLabelingJob#task_description}.</summary>
        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        string TaskDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_time_limit_in_seconds SagemakerLabelingJob#task_time_limit_in_seconds}.</summary>
        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double TaskTimeLimitInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_title SagemakerLabelingJob#task_title}.</summary>
        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        string TaskTitle
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#workteam_arn SagemakerLabelingJob#workteam_arn}.</summary>
        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        string WorkteamArn
        {
            get;
        }

        /// <summary>annotation_consolidation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_config SagemakerLabelingJob#annotation_consolidation_config}
        /// </remarks>
        [JsiiProperty(name: "annotationConsolidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnnotationConsolidationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_concurrent_task_count SagemakerLabelingJob#max_concurrent_task_count}.</summary>
        [JsiiProperty(name: "maxConcurrentTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentTaskCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#pre_human_task_lambda_arn SagemakerLabelingJob#pre_human_task_lambda_arn}.</summary>
        [JsiiProperty(name: "preHumanTaskLambdaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreHumanTaskLambdaArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_workforce_task_price block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#public_workforce_task_price SagemakerLabelingJob#public_workforce_task_price}
        /// </remarks>
        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicWorkforceTaskPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_availability_lifetime_in_seconds SagemakerLabelingJob#task_availability_lifetime_in_seconds}.</summary>
        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskAvailabilityLifetimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_keywords SagemakerLabelingJob#task_keywords}.</summary>
        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TaskKeywords
        {
            get
            {
                return null;
            }
        }

        /// <summary>ui_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#ui_config SagemakerLabelingJob#ui_config}
        /// </remarks>
        [JsiiProperty(name: "uiConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UiConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#number_of_human_workers_per_data_object SagemakerLabelingJob#number_of_human_workers_per_data_object}.</summary>
            [JsiiProperty(name: "numberOfHumanWorkersPerDataObject", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfHumanWorkersPerDataObject
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_description SagemakerLabelingJob#task_description}.</summary>
            [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_time_limit_in_seconds SagemakerLabelingJob#task_time_limit_in_seconds}.</summary>
            [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double TaskTimeLimitInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_title SagemakerLabelingJob#task_title}.</summary>
            [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskTitle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#workteam_arn SagemakerLabelingJob#workteam_arn}.</summary>
            [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkteamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>annotation_consolidation_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_config SagemakerLabelingJob#annotation_consolidation_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "annotationConsolidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AnnotationConsolidationConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_concurrent_task_count SagemakerLabelingJob#max_concurrent_task_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentTaskCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#pre_human_task_lambda_arn SagemakerLabelingJob#pre_human_task_lambda_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preHumanTaskLambdaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreHumanTaskLambdaArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_workforce_task_price block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#public_workforce_task_price SagemakerLabelingJob#public_workforce_task_price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PublicWorkforceTaskPrice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_availability_lifetime_in_seconds SagemakerLabelingJob#task_availability_lifetime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskAvailabilityLifetimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#task_keywords SagemakerLabelingJob#task_keywords}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TaskKeywords
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ui_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#ui_config SagemakerLabelingJob#ui_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uiConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UiConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
