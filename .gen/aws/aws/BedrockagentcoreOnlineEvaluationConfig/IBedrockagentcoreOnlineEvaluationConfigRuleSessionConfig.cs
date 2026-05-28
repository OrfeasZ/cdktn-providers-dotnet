using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOnlineEvaluationConfig
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigRuleSessionConfig), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigRuleSessionConfig")]
    public interface IBedrockagentcoreOnlineEvaluationConfigRuleSessionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#session_timeout_minutes BedrockagentcoreOnlineEvaluationConfig#session_timeout_minutes}.</summary>
        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double SessionTimeoutMinutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreOnlineEvaluationConfigRuleSessionConfig), fullyQualifiedName: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigRuleSessionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreOnlineEvaluationConfig.IBedrockagentcoreOnlineEvaluationConfigRuleSessionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#session_timeout_minutes BedrockagentcoreOnlineEvaluationConfig#session_timeout_minutes}.</summary>
            [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double SessionTimeoutMinutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
