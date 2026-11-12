using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSecurityCustomTopics
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSecurityCustomTopics.AiSecurityCustomTopicsTopics")]
    public class AiSecurityCustomTopicsTopics : cloudflare.AiSecurityCustomTopics.IAiSecurityCustomTopicsTopics
    {
        /// <summary>Unique label identifier. Must contain only lowercase letters (a–z), digits (0–9), and hyphens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_security_custom_topics#label AiSecurityCustomTopics#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public string Label
        {
            get;
            set;
        }

        /// <summary>Description of the topic category.</summary>
        /// <remarks>
        /// Must contain 2–50 UTF-8 bytes. Text in any language is supported, including spaces, numbers, punctuation, and symbols. Tabs, line breaks, invalid text, and invisible formatting characters are not allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_security_custom_topics#topic AiSecurityCustomTopics#topic}
        /// </remarks>
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        public string Topic
        {
            get;
            set;
        }
    }
}
