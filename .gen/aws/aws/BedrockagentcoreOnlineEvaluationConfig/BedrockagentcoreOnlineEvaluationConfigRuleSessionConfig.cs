using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOnlineEvaluationConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreOnlineEvaluationConfig.BedrockagentcoreOnlineEvaluationConfigRuleSessionConfig")]
    public class BedrockagentcoreOnlineEvaluationConfigRuleSessionConfig : aws.BedrockagentcoreOnlineEvaluationConfig.IBedrockagentcoreOnlineEvaluationConfigRuleSessionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_online_evaluation_config#session_timeout_minutes BedrockagentcoreOnlineEvaluationConfig#session_timeout_minutes}.</summary>
        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double SessionTimeoutMinutes
        {
            get;
            set;
        }
    }
}
