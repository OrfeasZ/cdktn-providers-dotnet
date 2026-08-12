using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig")]
    public interface IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#flow_definition_arn BedrockEvaluationJob#flow_definition_arn}.</summary>
        [JsiiProperty(name: "flowDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FlowDefinitionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#instructions BedrockEvaluationJob#instructions}.</summary>
        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instructions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#flow_definition_arn BedrockEvaluationJob#flow_definition_arn}.</summary>
            [JsiiProperty(name: "flowDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FlowDefinitionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#instructions BedrockEvaluationJob#instructions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instructions
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
