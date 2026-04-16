using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_count SagemakerAlgorithm#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#ultra_server_id SagemakerAlgorithm#ultra_server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ultraServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UltraServerId
        {
            get;
            set;
        }
    }
}
