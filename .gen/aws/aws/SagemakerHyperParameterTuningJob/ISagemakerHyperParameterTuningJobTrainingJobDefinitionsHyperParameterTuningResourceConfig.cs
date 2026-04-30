using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#allocation_strategy SagemakerHyperParameterTuningJob#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_configs SagemakerHyperParameterTuningJob#instance_configs}
        /// </remarks>
        [JsiiProperty(name: "instanceConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfigInstanceConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstanceConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_kms_key_id SagemakerHyperParameterTuningJob#volume_kms_key_id}.</summary>
        [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeKmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_size_in_gb SagemakerHyperParameterTuningJob#volume_size_in_gb}.</summary>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#allocation_strategy SagemakerHyperParameterTuningJob#allocation_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_configs SagemakerHyperParameterTuningJob#instance_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfigInstanceConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstanceConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_kms_key_id SagemakerHyperParameterTuningJob#volume_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#volume_size_in_gb SagemakerHyperParameterTuningJob#volume_size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
