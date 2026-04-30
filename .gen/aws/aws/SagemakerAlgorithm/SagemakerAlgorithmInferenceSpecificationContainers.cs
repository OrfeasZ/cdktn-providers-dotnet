using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainers")]
    public class SagemakerAlgorithmInferenceSpecificationContainers : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainers
    {
        private object? _additionalS3DataSource;

        /// <summary>additional_s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#additional_s3_data_source SagemakerAlgorithm#additional_s3_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalS3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalS3DataSource
        {
            get => _additionalS3DataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalS3DataSource = value;
            }
        }

        private object? _baseModel;

        /// <summary>base_model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#base_model SagemakerAlgorithm#base_model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseModel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersBaseModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BaseModel
        {
            get => _baseModel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersBaseModel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersBaseModel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _baseModel = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#container_hostname SagemakerAlgorithm#container_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#environment SagemakerAlgorithm#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#framework SagemakerAlgorithm#framework}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "framework", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Framework
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#framework_version SagemakerAlgorithm#framework_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "frameworkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FrameworkVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#image SagemakerAlgorithm#image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#image_digest SagemakerAlgorithm#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        private object? _isCheckpoint;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#is_checkpoint SagemakerAlgorithm#is_checkpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCheckpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCheckpoint
        {
            get => _isCheckpoint;
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
                _isCheckpoint = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#model_data_etag SagemakerAlgorithm#model_data_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelDataEtag
        {
            get;
            set;
        }

        private object? _modelDataSource;

        /// <summary>model_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#model_data_source SagemakerAlgorithm#model_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModelDataSource
        {
            get => _modelDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modelDataSource = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#model_data_url SagemakerAlgorithm#model_data_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelDataUrl
        {
            get;
            set;
        }

        private object? _modelInput;

        /// <summary>model_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#model_input SagemakerAlgorithm#model_input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModelInput
        {
            get => _modelInput;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelInput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelInput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modelInput = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#nearest_model_name SagemakerAlgorithm#nearest_model_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nearestModelName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NearestModelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#product_id SagemakerAlgorithm#product_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductId
        {
            get;
            set;
        }
    }
}
