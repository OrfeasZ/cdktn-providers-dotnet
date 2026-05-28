using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOnlineEvaluationConfig
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigEvaluator), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigEvaluator")]
    public interface IBedrockagentcoreOnlineEvaluationConfigEvaluator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#evaluator_id BedrockagentcoreOnlineEvaluationConfig#evaluator_id}.</summary>
        [JsiiProperty(name: "evaluatorId", typeJson: "{\"primitive\":\"string\"}")]
        string EvaluatorId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigEvaluator), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigEvaluator")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreOnlineEvaluationConfig.IBedrockagentcoreOnlineEvaluationConfigEvaluator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#evaluator_id BedrockagentcoreOnlineEvaluationConfig#evaluator_id}.</summary>
            [JsiiProperty(name: "evaluatorId", typeJson: "{\"primitive\":\"string\"}")]
            public string EvaluatorId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
