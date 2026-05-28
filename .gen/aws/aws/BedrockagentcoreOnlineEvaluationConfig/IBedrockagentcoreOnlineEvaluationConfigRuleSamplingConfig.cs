using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOnlineEvaluationConfig
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig")]
    public interface IBedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#sampling_percentage BedrockagentcoreOnlineEvaluationConfig#sampling_percentage}.</summary>
        [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double SamplingPercentage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreOnlineEvaluationConfig.IBedrockagentcoreOnlineEvaluationConfigRuleSamplingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#sampling_percentage BedrockagentcoreOnlineEvaluationConfig#sampling_percentage}.</summary>
            [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double SamplingPercentage
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
