using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigShuffleConfig")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigShuffleConfig : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#seed SagemakerAlgorithm#seed}.</summary>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
        public double Seed
        {
            get;
            set;
        }
    }
}
