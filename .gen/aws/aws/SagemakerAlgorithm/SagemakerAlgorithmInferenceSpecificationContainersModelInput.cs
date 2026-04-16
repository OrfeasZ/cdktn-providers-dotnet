using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelInput")]
    public class SagemakerAlgorithmInferenceSpecificationContainersModelInput : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#data_input_config SagemakerAlgorithm#data_input_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataInputConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataInputConfig
        {
            get;
            set;
        }
    }
}
