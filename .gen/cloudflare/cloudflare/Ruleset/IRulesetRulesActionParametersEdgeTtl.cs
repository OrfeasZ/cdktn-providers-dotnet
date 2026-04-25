using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersEdgeTtl), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl")]
    public interface IRulesetRulesActionParametersEdgeTtl
    {
        /// <summary>The edge TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mode Ruleset#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>The edge TTL (in seconds) if you choose the "override_origin" mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of TTLs to apply to specific status codes or status code ranges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code_ttl Ruleset#status_code_ttl}
        /// </remarks>
        [JsiiProperty(name: "statusCodeTtl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusCodeTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersEdgeTtl), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The edge TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mode Ruleset#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The edge TTL (in seconds) if you choose the "override_origin" mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#default Ruleset#default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Default
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A list of TTLs to apply to specific status codes or status code ranges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code_ttl Ruleset#status_code_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCodeTtl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusCodeTtl
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
