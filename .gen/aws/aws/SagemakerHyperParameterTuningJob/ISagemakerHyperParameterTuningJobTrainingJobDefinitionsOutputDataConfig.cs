using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#s3_output_path SagemakerHyperParameterTuningJob#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        string S3OutputPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#compression_type SagemakerHyperParameterTuningJob#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#kms_key_id SagemakerHyperParameterTuningJob#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#s3_output_path SagemakerHyperParameterTuningJob#s3_output_path}.</summary>
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
            public string S3OutputPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#compression_type SagemakerHyperParameterTuningJob#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#kms_key_id SagemakerHyperParameterTuningJob#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
