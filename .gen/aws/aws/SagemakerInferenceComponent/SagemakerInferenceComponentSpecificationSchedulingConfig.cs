using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationSchedulingConfig")]
    public class SagemakerInferenceComponentSpecificationSchedulingConfig : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#placement_strategy SagemakerInferenceComponent#placement_strategy}.</summary>
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string PlacementStrategy
        {
            get;
            set;
        }

        private object? _availabilityZoneBalance;

        /// <summary>availability_zone_balance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#availability_zone_balance SagemakerInferenceComponent#availability_zone_balance}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneBalance", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AvailabilityZoneBalance
        {
            get => _availabilityZoneBalance;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _availabilityZoneBalance = value;
            }
        }
    }
}
