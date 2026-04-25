using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersAutominify), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersAutominify")]
    public interface IRulesetRulesActionParametersAutominify
    {
        /// <summary>Whether to minify CSS files.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#css Ruleset#css}
        /// </remarks>
        [JsiiProperty(name: "css", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Css
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to minify HTML files.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#html Ruleset#html}
        /// </remarks>
        [JsiiProperty(name: "html", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Html
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to minify JavaScript files.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#js Ruleset#js}
        /// </remarks>
        [JsiiProperty(name: "js", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Js
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersAutominify), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersAutominify")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersAutominify
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to minify CSS files.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#css Ruleset#css}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "css", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Css
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to minify HTML files.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#html Ruleset#html}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "html", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Html
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to minify JavaScript files.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#js Ruleset#js}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "js", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Js
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
