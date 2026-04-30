using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfig")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfig : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#instance_count SagemakerAlgorithm#instance_count}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#instance_groups SagemakerAlgorithm#instance_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instanceGroups = value;
            }
        }

        private object? _instancePlacementConfig;

        /// <summary>instance_placement_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#instance_placement_config SagemakerAlgorithm#instance_placement_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancePlacementConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instancePlacementConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#instance_type SagemakerAlgorithm#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#keep_alive_period_in_seconds SagemakerAlgorithm#keep_alive_period_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepAlivePeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepAlivePeriodInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_plan_arn SagemakerAlgorithm#training_plan_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingPlanArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingPlanArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#volume_kms_key_id SagemakerAlgorithm#volume_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#volume_size_in_gb SagemakerAlgorithm#volume_size_in_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSizeInGb
        {
            get;
            set;
        }
    }
}
