using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig")]
    public class BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#flow_definition_arn BedrockEvaluationJob#flow_definition_arn}.</summary>
        [JsiiProperty(name: "flowDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FlowDefinitionArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#instructions BedrockEvaluationJob#instructions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instructions
        {
            get;
            set;
        }
    }
}
