using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#max_pending_time_in_seconds SagemakerAlgorithm#max_pending_time_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPendingTimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#max_runtime_in_seconds SagemakerAlgorithm#max_runtime_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRuntimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#max_wait_time_in_seconds SagemakerAlgorithm#max_wait_time_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWaitTimeInSeconds
        {
            get;
            set;
        }
    }
}
