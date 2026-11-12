using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.BotManagement
{
    [JsiiByValue(fqn: "cloudflare.botManagement.BotManagementAiAgents")]
    public class BotManagementAiAgents : cloudflare.BotManagement.IBotManagementAiAgents
    {
        /// <summary>Action to apply to one supported personal AI agent. Available values: "disabled", "block", "only_on_ad_pages".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/bot_management#anthropic_agent BotManagement#anthropic_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnthropicAgent
        {
            get;
            set;
        }

        /// <summary>Action to apply to one supported personal AI agent. Available values: "disabled", "block", "only_on_ad_pages".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/bot_management#google_agent BotManagement#google_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GoogleAgent
        {
            get;
            set;
        }

        /// <summary>Action to apply to one supported personal AI agent. Available values: "disabled", "block", "only_on_ad_pages".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/bot_management#instinct BotManagement#instinct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instinct", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instinct
        {
            get;
            set;
        }

        /// <summary>Action to apply to one supported personal AI agent. Available values: "disabled", "block", "only_on_ad_pages".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/bot_management#muse BotManagement#muse}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "muse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Muse
        {
            get;
            set;
        }

        /// <summary>Action to apply to one supported personal AI agent. Available values: "disabled", "block", "only_on_ad_pages".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/bot_management#openai_agent BotManagement#openai_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openaiAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpenaiAgent
        {
            get;
            set;
        }
    }
}
