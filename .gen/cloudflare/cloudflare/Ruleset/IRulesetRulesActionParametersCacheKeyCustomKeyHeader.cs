using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyHeader), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyHeader
    {
        /// <summary>Checks for the presence of these header names.</summary>
        /// <remarks>
        /// The presence of these headers is used in building the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#check_presence Ruleset#check_presence}
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

        /// <summary>For each header name and list of values combination, check if the request header contains any of the values provided.</summary>
        /// <remarks>
        /// The presence of the request header and whether any of the values provided are contained in the request header value is used in building the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#contains Ruleset#contains}
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

        /// <summary>Whether or not to include the origin header.</summary>
        /// <remarks>
        /// A value of true will exclude the origin header in the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exclude_origin Ruleset#exclude_origin}
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

        /// <summary>Include these headers' names and their values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
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

            /// <summary>Checks for the presence of these header names.</summary>
            /// <remarks>
            /// The presence of these headers is used in building the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#check_presence Ruleset#check_presence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckPresence
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>For each header name and list of values combination, check if the request header contains any of the values provided.</summary>
            /// <remarks>
            /// The presence of the request header and whether any of the values provided are contained in the request header value is used in building the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#contains Ruleset#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Contains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether or not to include the origin header.</summary>
            /// <remarks>
            /// A value of true will exclude the origin header in the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exclude_origin Ruleset#exclude_origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeOrigin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Include these headers' names and their values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
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
