using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobResourceConfigInstancePlacementConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfig")]
    public interface ISagemakerTrainingJobResourceConfigInstancePlacementConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_multiple_jobs SagemakerTrainingJob#enable_multiple_jobs}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#placement_specifications SagemakerTrainingJob#placement_specifications}
        /// </remarks>
        [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlacementSpecifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobResourceConfigInstancePlacementConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_multiple_jobs SagemakerTrainingJob#enable_multiple_jobs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMultipleJobs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMultipleJobs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#placement_specifications SagemakerTrainingJob#placement_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlacementSpecifications
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
