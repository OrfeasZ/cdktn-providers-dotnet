using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKey), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKey")]
    public interface IRulesetRulesActionParametersCacheKey
    {
        /// <summary>Whether to separate cached content based on the visitor's device type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_by_device_type Ruleset#cache_by_device_type}
        /// </remarks>
        [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheByDeviceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to protect from web cache deception attacks, while allowing static assets to be cached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_deception_armor Ruleset#cache_deception_armor}
        /// </remarks>
        [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheDeceptionArmor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which components of the request are included or excluded from the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#custom_key Ruleset#custom_key}
        /// </remarks>
        [JsiiProperty(name: "customKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey? CustomKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to treat requests with the same query parameters the same, regardless of the order those query parameters are in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#ignore_query_strings_order Ruleset#ignore_query_strings_order}
        /// </remarks>
        [JsiiProperty(name: "ignoreQueryStringsOrder", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreQueryStringsOrder
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKey), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKey")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to separate cached content based on the visitor's device type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_by_device_type Ruleset#cache_by_device_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CacheByDeviceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to protect from web cache deception attacks, while allowing static assets to be cached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_deception_armor Ruleset#cache_deception_armor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CacheDeceptionArmor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Which components of the request are included or excluded from the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#custom_key Ruleset#custom_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKey\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey? CustomKey
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey?>();
            }

            /// <summary>Whether to treat requests with the same query parameters the same, regardless of the order those query parameters are in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#ignore_query_strings_order Ruleset#ignore_query_strings_order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreQueryStringsOrder", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreQueryStringsOrder
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
