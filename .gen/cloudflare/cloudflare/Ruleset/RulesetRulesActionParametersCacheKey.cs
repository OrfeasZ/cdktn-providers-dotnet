using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersCacheKey")]
    public class RulesetRulesActionParametersCacheKey : cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey
    {
        private object? _cacheByDeviceType;

        /// <summary>Whether to separate cached content based on the visitor's device type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_by_device_type Ruleset#cache_by_device_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CacheByDeviceType
        {
            get => _cacheByDeviceType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cacheByDeviceType = value;
            }
        }

        private object? _cacheDeceptionArmor;

        /// <summary>Whether to protect from web cache deception attacks, while allowing static assets to be cached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_deception_armor Ruleset#cache_deception_armor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CacheDeceptionArmor
        {
            get => _cacheDeceptionArmor;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cacheDeceptionArmor = value;
            }
        }

        /// <summary>Which components of the request are included or excluded from the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#custom_key Ruleset#custom_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKey\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey? CustomKey
        {
            get;
            set;
        }

        private object? _ignoreQueryStringsOrder;

        /// <summary>Whether to treat requests with the same query parameters the same, regardless of the order those query parameters are in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#ignore_query_strings_order Ruleset#ignore_query_strings_order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreQueryStringsOrder", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreQueryStringsOrder
        {
            get => _ignoreQueryStringsOrder;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreQueryStringsOrder = value;
            }
        }
    }
}
