using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentRuntimeConfig")]
    public class SagemakerInferenceComponentRuntimeConfig : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#copy_count SagemakerInferenceComponent#copy_count}.</summary>
        [JsiiProperty(name: "copyCount", typeJson: "{\"primitive\":\"number\"}")]
        public double CopyCount
        {
            get;
            set;
        }
    }
}
