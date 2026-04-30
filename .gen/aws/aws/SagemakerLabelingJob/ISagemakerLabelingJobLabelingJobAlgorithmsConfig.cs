using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobLabelingJobAlgorithmsConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfig")]
    public interface ISagemakerLabelingJobLabelingJobAlgorithmsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#labeling_job_algorithm_specification_arn SagemakerLabelingJob#labeling_job_algorithm_specification_arn}.</summary>
        [JsiiProperty(name: "labelingJobAlgorithmSpecificationArn", typeJson: "{\"primitive\":\"string\"}")]
        string LabelingJobAlgorithmSpecificationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#initial_active_learning_model_arn SagemakerLabelingJob#initial_active_learning_model_arn}.</summary>
        [JsiiProperty(name: "initialActiveLearningModelArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitialActiveLearningModelArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>labeling_job_resource_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#labeling_job_resource_config SagemakerLabelingJob#labeling_job_resource_config}
        /// </remarks>
        [JsiiProperty(name: "labelingJobResourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LabelingJobResourceConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobLabelingJobAlgorithmsConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#labeling_job_algorithm_specification_arn SagemakerLabelingJob#labeling_job_algorithm_specification_arn}.</summary>
            [JsiiProperty(name: "labelingJobAlgorithmSpecificationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LabelingJobAlgorithmSpecificationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#initial_active_learning_model_arn SagemakerLabelingJob#initial_active_learning_model_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialActiveLearningModelArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitialActiveLearningModelArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>labeling_job_resource_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#labeling_job_resource_config SagemakerLabelingJob#labeling_job_resource_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelingJobResourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LabelingJobResourceConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
