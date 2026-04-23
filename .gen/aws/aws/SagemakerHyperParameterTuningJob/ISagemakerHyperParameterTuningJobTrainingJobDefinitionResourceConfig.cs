using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_groups SagemakerHyperParameterTuningJob#instance_groups}
        /// </remarks>
        [JsiiProperty(name: "instanceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstanceGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_placement_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_placement_config SagemakerHyperParameterTuningJob#instance_placement_config}
        /// </remarks>
        [JsiiProperty(name: "instancePlacementConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstancePlacementConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#keep_alive_period_in_seconds SagemakerHyperParameterTuningJob#keep_alive_period_in_seconds}.</summary>
        [JsiiProperty(name: "keepAlivePeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeepAlivePeriodInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_plan_arn SagemakerHyperParameterTuningJob#training_plan_arn}.</summary>
        [JsiiProperty(name: "trainingPlanArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingPlanArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_kms_key_id SagemakerHyperParameterTuningJob#volume_kms_key_id}.</summary>
        [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeKmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_size_in_gb SagemakerHyperParameterTuningJob#volume_size_in_gb}.</summary>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>instance_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_groups SagemakerHyperParameterTuningJob#instance_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstanceGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>instance_placement_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_placement_config SagemakerHyperParameterTuningJob#instance_placement_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instancePlacementConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstancePlacementConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#keep_alive_period_in_seconds SagemakerHyperParameterTuningJob#keep_alive_period_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keepAlivePeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeepAlivePeriodInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_plan_arn SagemakerHyperParameterTuningJob#training_plan_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingPlanArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingPlanArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_kms_key_id SagemakerHyperParameterTuningJob#volume_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_size_in_gb SagemakerHyperParameterTuningJob#volume_size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
