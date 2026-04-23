using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSource")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSource : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#s3_data_type SagemakerAlgorithm#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        public string S3DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#s3_uri SagemakerAlgorithm#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#attribute_names SagemakerAlgorithm#attribute_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeNames
        {
            get;
            set;
        }

        private object? _hubAccessConfig;

        /// <summary>hub_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#hub_access_config SagemakerAlgorithm#hub_access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hubAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hubAccessConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#instance_group_names SagemakerAlgorithm#instance_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InstanceGroupNames
        {
            get;
            set;
        }

        private object? _modelAccessConfig;

        /// <summary>model_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#model_access_config SagemakerAlgorithm#model_access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modelAccessConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#s3_data_distribution_type SagemakerAlgorithm#s3_data_distribution_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3DataDistributionType
        {
            get;
            set;
        }
    }
}
