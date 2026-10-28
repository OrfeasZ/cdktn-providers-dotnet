using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentSpecificationsSchedulingConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfig")]
    public interface ISagemakerInferenceComponentSpecificationsSchedulingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#placement_strategy SagemakerInferenceComponent#placement_strategy}.</summary>
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string PlacementStrategy
        {
            get;
        }

        /// <summary>availability_zone_balance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#availability_zone_balance SagemakerInferenceComponent#availability_zone_balance}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "availabilityZoneBalance", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AvailabilityZoneBalance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentSpecificationsSchedulingConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsSchedulingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#placement_strategy SagemakerInferenceComponent#placement_strategy}.</summary>
            [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string PlacementStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>availability_zone_balance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#availability_zone_balance SagemakerInferenceComponent#availability_zone_balance}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneBalance", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AvailabilityZoneBalance
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
