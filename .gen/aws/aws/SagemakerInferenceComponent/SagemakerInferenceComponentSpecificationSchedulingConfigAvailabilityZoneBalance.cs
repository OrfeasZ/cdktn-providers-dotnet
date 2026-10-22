using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance")]
    public class SagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfigAvailabilityZoneBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#enforcement_mode SagemakerInferenceComponent#enforcement_mode}.</summary>
        [JsiiProperty(name: "enforcementMode", typeJson: "{\"primitive\":\"string\"}")]
        public string EnforcementMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#max_imbalance SagemakerInferenceComponent#max_imbalance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxImbalance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxImbalance
        {
            get;
            set;
        }
    }
}
