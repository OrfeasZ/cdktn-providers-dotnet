using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecification), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecification")]
    public interface ISagemakerAlgorithmValidationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#validation_role SagemakerAlgorithm#validation_role}.</summary>
        [JsiiProperty(name: "validationRole", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationRole
        {
            get;
        }

        /// <summary>validation_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#validation_profiles SagemakerAlgorithm#validation_profiles}
        /// </remarks>
        [JsiiProperty(name: "validationProfiles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidationProfiles
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecification), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#validation_role SagemakerAlgorithm#validation_role}.</summary>
            [JsiiProperty(name: "validationRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>validation_profiles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#validation_profiles SagemakerAlgorithm#validation_profiles}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationProfiles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ValidationProfiles
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
