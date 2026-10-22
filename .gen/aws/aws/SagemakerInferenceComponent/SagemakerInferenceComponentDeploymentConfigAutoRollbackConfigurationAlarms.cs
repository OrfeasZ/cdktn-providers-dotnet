using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms")]
    public class SagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#alarm_name SagemakerInferenceComponent#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        public string AlarmName
        {
            get;
            set;
        }
    }
}
