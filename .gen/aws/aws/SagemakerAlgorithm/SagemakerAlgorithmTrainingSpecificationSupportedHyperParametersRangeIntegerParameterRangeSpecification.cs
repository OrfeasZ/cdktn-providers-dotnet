using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParametersRangeIntegerParameterRangeSpecification")]
    public class SagemakerAlgorithmTrainingSpecificationSupportedHyperParametersRangeIntegerParameterRangeSpecification : aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParametersRangeIntegerParameterRangeSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#max_value SagemakerAlgorithm#max_value}.</summary>
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}")]
        public string MaxValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#min_value SagemakerAlgorithm#min_value}.</summary>
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}")]
        public string MinValue
        {
            get;
            set;
        }
    }
}
