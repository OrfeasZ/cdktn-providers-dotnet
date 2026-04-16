using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#enable_multiple_jobs SagemakerAlgorithm#enable_multiple_jobs}.</summary>
        [JsiiProperty(name: "enableMultipleJobs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMultipleJobs
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#placement_specifications SagemakerAlgorithm#placement_specifications}
        /// </remarks>
        [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlacementSpecifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#enable_multiple_jobs SagemakerAlgorithm#enable_multiple_jobs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMultipleJobs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMultipleJobs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#placement_specifications SagemakerAlgorithm#placement_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlacementSpecifications
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
