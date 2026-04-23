using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfiles), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfiles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#profile_name SagemakerAlgorithm#profile_name}.</summary>
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        string ProfileName
        {
            get;
        }

        /// <summary>training_job_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#training_job_definition SagemakerAlgorithm#training_job_definition}
        /// </remarks>
        [JsiiProperty(name: "trainingJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrainingJobDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>transform_job_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_job_definition SagemakerAlgorithm#transform_job_definition}
        /// </remarks>
        [JsiiProperty(name: "transformJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformJobDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfiles), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfiles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#profile_name SagemakerAlgorithm#profile_name}.</summary>
            [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProfileName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>training_job_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#training_job_definition SagemakerAlgorithm#training_job_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrainingJobDefinition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transform_job_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#transform_job_definition SagemakerAlgorithm#transform_job_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformJobDefinition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
