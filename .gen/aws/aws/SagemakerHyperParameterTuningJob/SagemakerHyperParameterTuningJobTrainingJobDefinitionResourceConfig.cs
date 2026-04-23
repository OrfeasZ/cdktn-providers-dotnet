using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        private object? _instanceGroups;

        /// <summary>instance_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_groups SagemakerHyperParameterTuningJob#instance_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InstanceGroups
        {
            get => _instanceGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instanceGroups = value;
            }
        }

        private object? _instancePlacementConfig;

        /// <summary>instance_placement_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_placement_config SagemakerHyperParameterTuningJob#instance_placement_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancePlacementConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InstancePlacementConfig
        {
            get => _instancePlacementConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instancePlacementConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#keep_alive_period_in_seconds SagemakerHyperParameterTuningJob#keep_alive_period_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepAlivePeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepAlivePeriodInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_plan_arn SagemakerHyperParameterTuningJob#training_plan_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingPlanArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingPlanArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_kms_key_id SagemakerHyperParameterTuningJob#volume_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_size_in_gb SagemakerHyperParameterTuningJob#volume_size_in_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSizeInGb
        {
            get;
            set;
        }
    }
}
