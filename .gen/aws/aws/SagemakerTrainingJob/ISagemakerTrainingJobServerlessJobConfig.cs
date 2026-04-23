using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobServerlessJobConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobServerlessJobConfig")]
    public interface ISagemakerTrainingJobServerlessJobConfig
    {
        /// <summary>Base model ARN in SageMaker Public Hub. SageMaker always selects the latest version of the provided model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#base_model_arn SagemakerTrainingJob#base_model_arn}
        /// </remarks>
        [JsiiProperty(name: "baseModelArn", typeJson: "{\"primitive\":\"string\"}")]
        string BaseModelArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#job_type SagemakerTrainingJob#job_type}.</summary>
        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        string JobType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#accept_eula SagemakerTrainingJob#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptEula
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#customization_technique SagemakerTrainingJob#customization_technique}.</summary>
        [JsiiProperty(name: "customizationTechnique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomizationTechnique
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluation_type SagemakerTrainingJob#evaluation_type}.</summary>
        [JsiiProperty(name: "evaluationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvaluationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluator_arn SagemakerTrainingJob#evaluator_arn}.</summary>
        [JsiiProperty(name: "evaluatorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvaluatorArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#peft SagemakerTrainingJob#peft}.</summary>
        [JsiiProperty(name: "peft", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Peft
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobServerlessJobConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobServerlessJobConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobServerlessJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Base model ARN in SageMaker Public Hub. SageMaker always selects the latest version of the provided model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#base_model_arn SagemakerTrainingJob#base_model_arn}
            /// </remarks>
            [JsiiProperty(name: "baseModelArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BaseModelArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#job_type SagemakerTrainingJob#job_type}.</summary>
            [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#accept_eula SagemakerTrainingJob#accept_eula}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptEula
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#customization_technique SagemakerTrainingJob#customization_technique}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customizationTechnique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomizationTechnique
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluation_type SagemakerTrainingJob#evaluation_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evaluationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvaluationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluator_arn SagemakerTrainingJob#evaluator_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evaluatorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvaluatorArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#peft SagemakerTrainingJob#peft}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peft", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Peft
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
