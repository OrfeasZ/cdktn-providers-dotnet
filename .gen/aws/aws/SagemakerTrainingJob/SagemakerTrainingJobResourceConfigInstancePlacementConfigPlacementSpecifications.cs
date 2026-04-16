using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications")]
    public class SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications : aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#instance_count SagemakerTrainingJob#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#ultra_server_id SagemakerTrainingJob#ultra_server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ultraServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UltraServerId
        {
            get;
            set;
        }
    }
}
