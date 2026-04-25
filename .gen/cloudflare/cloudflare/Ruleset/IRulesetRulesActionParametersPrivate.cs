using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersPrivate), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersPrivate")]
    public interface IRulesetRulesActionParametersPrivate
    {
        /// <summary>The operation to perform. Available values: "set", "remove".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#operation Ruleset#operation}
        /// </remarks>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Whether to apply the directive only to Cloudflare's cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#cloudflare_only Ruleset#cloudflare_only}
        /// </remarks>
        [JsiiProperty(name: "cloudflareOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudflareOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>The qualifiers for the directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#qualifiers Ruleset#qualifiers}
        /// </remarks>
        [JsiiProperty(name: "qualifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Qualifiers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersPrivate), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersPrivate")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersPrivate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The operation to perform. Available values: "set", "remove".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#operation Ruleset#operation}
            /// </remarks>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether to apply the directive only to Cloudflare's cache.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#cloudflare_only Ruleset#cloudflare_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudflareOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudflareOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The qualifiers for the directive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#qualifiers Ruleset#qualifiers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qualifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Qualifiers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
