using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance")]
    public interface ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#enforcement_mode SagemakerInferenceComponent#enforcement_mode}.</summary>
        [JsiiProperty(name: "enforcementMode", typeJson: "{\"primitive\":\"string\"}")]
        string EnforcementMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#max_imbalance SagemakerInferenceComponent#max_imbalance}.</summary>
        [JsiiProperty(name: "maxImbalance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxImbalance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsSchedulingConfigAvailabilityZoneBalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#enforcement_mode SagemakerInferenceComponent#enforcement_mode}.</summary>
            [JsiiProperty(name: "enforcementMode", typeJson: "{\"primitive\":\"string\"}")]
            public string EnforcementMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#max_imbalance SagemakerInferenceComponent#max_imbalance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxImbalance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxImbalance
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
