using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyHeader), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyHeader
    {
        /// <summary>A list of headers to check for the presence of.</summary>
        /// <remarks>
        /// The presence of these headers is included in the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#check_presence Ruleset#check_presence}
        /// </remarks>
        [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CheckPresence
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of header names to a list of values.</summary>
        /// <remarks>
        /// If a header is present in the request and contains any of the values provided, its value is included in the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#contains Ruleset#contains}
        /// </remarks>
        [JsiiProperty(name: "contains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Contains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to exclude the origin header in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exclude_origin Ruleset#exclude_origin}
        /// </remarks>
        [JsiiProperty(name: "excludeOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeOrigin
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of headers to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#include Ruleset#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyHeader), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of headers to check for the presence of.</summary>
            /// <remarks>
            /// The presence of these headers is included in the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#check_presence Ruleset#check_presence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckPresence
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A mapping of header names to a list of values.</summary>
            /// <remarks>
            /// If a header is present in the request and contains any of the values provided, its value is included in the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#contains Ruleset#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Contains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to exclude the origin header in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exclude_origin Ruleset#exclude_origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeOrigin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of headers to include in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#include Ruleset#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Include
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
