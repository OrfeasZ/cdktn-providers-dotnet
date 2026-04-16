using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersUri), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersUri")]
    public interface IRulesetRulesActionParametersUri
    {
        /// <summary>A URI path rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#path Ruleset#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersUriPath? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>A URI query rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#query Ruleset#query}
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQuery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery? Query
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersUri), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersUri")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersUri
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A URI path rewrite.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#path Ruleset#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPath\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersUriPath? Path
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersUriPath?>();
            }

            /// <summary>A URI query rewrite.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#query Ruleset#query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQuery\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery? Query
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery?>();
            }
        }
    }
}
