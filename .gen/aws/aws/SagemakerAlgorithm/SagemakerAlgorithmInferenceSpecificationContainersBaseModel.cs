using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersBaseModel")]
    public class SagemakerAlgorithmInferenceSpecificationContainersBaseModel : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersBaseModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_name SagemakerAlgorithm#hub_content_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HubContentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_version SagemakerAlgorithm#hub_content_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hubContentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HubContentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#recipe_name SagemakerAlgorithm#recipe_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recipeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecipeName
        {
            get;
            set;
        }
    }
}
