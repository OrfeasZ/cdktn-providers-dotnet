using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased), fullyQualifiedName: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigCodeBased")]
    public interface IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased
    {
        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_evaluator#lambda_config BedrockagentcoreEvaluator#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigCodeBasedLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased), fullyQualifiedName: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigCodeBased")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_evaluator#lambda_config BedrockagentcoreEvaluator#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigCodeBasedLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
