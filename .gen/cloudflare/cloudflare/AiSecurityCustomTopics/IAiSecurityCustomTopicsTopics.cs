using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSecurityCustomTopics
{
    [JsiiInterface(nativeType: typeof(IAiSecurityCustomTopicsTopics), fullyQualifiedName: "cloudflare.aiSecurityCustomTopics.AiSecurityCustomTopicsTopics")]
    public interface IAiSecurityCustomTopicsTopics
    {
        /// <summary>Unique label identifier. Must contain only lowercase letters (a–z), digits (0–9), and hyphens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_security_custom_topics#label AiSecurityCustomTopics#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        string Label
        {
            get;
        }

        /// <summary>Description of the topic category.</summary>
        /// <remarks>
        /// Must contain 2–50 UTF-8 bytes. Text in any language is supported, including spaces, numbers, punctuation, and symbols. Tabs, line breaks, invalid text, and invisible formatting characters are not allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_security_custom_topics#topic AiSecurityCustomTopics#topic}
        /// </remarks>
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        string Topic
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSecurityCustomTopicsTopics), fullyQualifiedName: "cloudflare.aiSecurityCustomTopics.AiSecurityCustomTopicsTopics")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSecurityCustomTopics.IAiSecurityCustomTopicsTopics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Unique label identifier. Must contain only lowercase letters (a–z), digits (0–9), and hyphens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_security_custom_topics#label AiSecurityCustomTopics#label}
            /// </remarks>
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
            public string Label
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
