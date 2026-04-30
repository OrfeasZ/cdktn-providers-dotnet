using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationLex), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLex")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationLex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#bot_alias_arn BedrockagentFlow#bot_alias_arn}.</summary>
        [JsiiProperty(name: "botAliasArn", typeJson: "{\"primitive\":\"string\"}")]
        string BotAliasArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#locale_id BedrockagentFlow#locale_id}.</summary>
        [JsiiProperty(name: "localeId", typeJson: "{\"primitive\":\"string\"}")]
        string LocaleId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationLex), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLex")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationLex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#bot_alias_arn BedrockagentFlow#bot_alias_arn}.</summary>
            [JsiiProperty(name: "botAliasArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BotAliasArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#locale_id BedrockagentFlow#locale_id}.</summary>
            [JsiiProperty(name: "localeId", typeJson: "{\"primitive\":\"string\"}")]
            public string LocaleId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
