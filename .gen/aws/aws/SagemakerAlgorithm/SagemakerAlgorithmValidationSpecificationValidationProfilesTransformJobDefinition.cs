using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#batch_strategy SagemakerAlgorithm#batch_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BatchStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#environment SagemakerAlgorithm#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_concurrent_transforms SagemakerAlgorithm#max_concurrent_transforms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentTransforms", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentTransforms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_payload_in_mb SagemakerAlgorithm#max_payload_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPayloadInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPayloadInMb
        {
            get;
            set;
        }

        private object? _transformInput;

        /// <summary>transform_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_input SagemakerAlgorithm#transform_input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransformInput
        {
            get => _transformInput;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformInput = value;
            }
        }

        private object? _transformOutput;

        /// <summary>transform_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_output SagemakerAlgorithm#transform_output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransformOutput
        {
            get => _transformOutput;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformOutput = value;
            }
        }

        private object? _transformResources;

        /// <summary>transform_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_resources SagemakerAlgorithm#transform_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransformResources
        {
            get => _transformResources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformResources = value;
            }
        }
    }
}
