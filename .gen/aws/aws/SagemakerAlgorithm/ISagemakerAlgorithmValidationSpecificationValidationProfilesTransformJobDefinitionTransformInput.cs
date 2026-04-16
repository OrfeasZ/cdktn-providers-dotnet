using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#compression_type SagemakerAlgorithm#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#content_type SagemakerAlgorithm#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#data_source SagemakerAlgorithm#data_source}
        /// </remarks>
        [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#split_type SagemakerAlgorithm#split_type}.</summary>
        [JsiiProperty(name: "splitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SplitType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#compression_type SagemakerAlgorithm#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#content_type SagemakerAlgorithm#content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#data_source SagemakerAlgorithm#data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#split_type SagemakerAlgorithm#split_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "splitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SplitType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
