using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobServerlessJobConfig")]
    public class SagemakerTrainingJobServerlessJobConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobServerlessJobConfig
    {
        /// <summary>Base model ARN in SageMaker Public Hub. SageMaker always selects the latest version of the provided model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#base_model_arn SagemakerTrainingJob#base_model_arn}
        /// </remarks>
        [JsiiProperty(name: "baseModelArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseModelArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#job_type SagemakerTrainingJob#job_type}.</summary>
        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobType
        {
            get;
            set;
        }

        private object? _acceptEula;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#accept_eula SagemakerTrainingJob#accept_eula}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceptEula
        {
            get => _acceptEula;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _acceptEula = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#customization_technique SagemakerTrainingJob#customization_technique}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customizationTechnique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomizationTechnique
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluation_type SagemakerTrainingJob#evaluation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evaluationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvaluationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#evaluator_arn SagemakerTrainingJob#evaluator_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evaluatorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvaluatorArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#peft SagemakerTrainingJob#peft}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peft", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Peft
        {
            get;
            set;
        }
    }
}
