using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#batch_strategy SagemakerAlgorithm#batch_strategy}.</summary>
        [JsiiProperty(name: "batchStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BatchStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#environment SagemakerAlgorithm#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_concurrent_transforms SagemakerAlgorithm#max_concurrent_transforms}.</summary>
        [JsiiProperty(name: "maxConcurrentTransforms", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentTransforms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_payload_in_mb SagemakerAlgorithm#max_payload_in_mb}.</summary>
        [JsiiProperty(name: "maxPayloadInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPayloadInMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>transform_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_input SagemakerAlgorithm#transform_input}
        /// </remarks>
        [JsiiProperty(name: "transformInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformInput
        {
            get
            {
                return null;
            }
        }

        /// <summary>transform_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_output SagemakerAlgorithm#transform_output}
        /// </remarks>
        [JsiiProperty(name: "transformOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformOutput
        {
            get
            {
                return null;
            }
        }

        /// <summary>transform_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_resources SagemakerAlgorithm#transform_resources}
        /// </remarks>
        [JsiiProperty(name: "transformResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformResources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#batch_strategy SagemakerAlgorithm#batch_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BatchStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#environment SagemakerAlgorithm#environment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Environment
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_concurrent_transforms SagemakerAlgorithm#max_concurrent_transforms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentTransforms", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentTransforms
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_payload_in_mb SagemakerAlgorithm#max_payload_in_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPayloadInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPayloadInMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>transform_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_input SagemakerAlgorithm#transform_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformInput
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transform_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_output SagemakerAlgorithm#transform_output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformOutput
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transform_resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_resources SagemakerAlgorithm#transform_resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformResources
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
