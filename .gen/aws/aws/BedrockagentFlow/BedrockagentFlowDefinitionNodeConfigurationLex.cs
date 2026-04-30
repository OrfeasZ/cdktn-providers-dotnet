using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLex")]
    public class BedrockagentFlowDefinitionNodeConfigurationLex : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationLex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#bot_alias_arn BedrockagentFlow#bot_alias_arn}.</summary>
        [JsiiProperty(name: "botAliasArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BotAliasArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#locale_id BedrockagentFlow#locale_id}.</summary>
        [JsiiProperty(name: "localeId", typeJson: "{\"primitive\":\"string\"}")]
        public string LocaleId
        {
            get;
            set;
        }
    }
}
