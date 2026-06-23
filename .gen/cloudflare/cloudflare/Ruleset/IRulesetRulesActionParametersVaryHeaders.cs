using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersVaryHeaders), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders")]
    public interface IRulesetRulesActionParametersVaryHeaders
    {
        /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>The set of languages to normalize against. Only valid for the `accept-language` header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#languages Ruleset#languages}
        /// </remarks>
        [JsiiProperty(name: "languages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Languages
        {
            get
            {
                return null;
            }
        }

        /// <summary>The set of media types to normalize against. Only valid for the `accept` header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#media_types Ruleset#media_types}
        /// </remarks>
        [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MediaTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersVaryHeaders), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#action Ruleset#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The set of languages to normalize against. Only valid for the `accept-language` header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#languages Ruleset#languages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "languages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Languages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The set of media types to normalize against. Only valid for the `accept` header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#media_types Ruleset#media_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MediaTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
