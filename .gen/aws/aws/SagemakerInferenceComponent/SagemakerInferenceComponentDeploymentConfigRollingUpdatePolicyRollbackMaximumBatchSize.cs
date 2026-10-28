using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize")]
    public class SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#type SagemakerInferenceComponent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#value SagemakerInferenceComponent#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
