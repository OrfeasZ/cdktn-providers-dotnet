using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSource")]
    public class SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSource : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#compression_type SagemakerAlgorithm#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public string CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#s3_data_type SagemakerAlgorithm#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        public string S3DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#s3_uri SagemakerAlgorithm#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#etag SagemakerAlgorithm#etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Etag
        {
            get;
            set;
        }

        private object? _hubAccessConfig;

        /// <summary>hub_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#hub_access_config SagemakerAlgorithm#hub_access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hubAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HubAccessConfig
        {
            get => _hubAccessConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hubAccessConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#manifest_etag SagemakerAlgorithm#manifest_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manifestEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManifestEtag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#manifest_s3_uri SagemakerAlgorithm#manifest_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manifestS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManifestS3Uri
        {
            get;
            set;
        }

        private object? _modelAccessConfig;

        /// <summary>model_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#model_access_config SagemakerAlgorithm#model_access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModelAccessConfig
        {
            get => _modelAccessConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modelAccessConfig = value;
            }
        }
    }
}
