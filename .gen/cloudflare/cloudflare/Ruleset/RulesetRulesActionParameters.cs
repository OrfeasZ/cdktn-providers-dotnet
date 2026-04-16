using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParameters")]
    public class RulesetRulesActionParameters : cloudflare.Ruleset.IRulesetRulesActionParameters
    {
        /// <summary>A list of additional ports that caching should be enabled on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#additional_cacheable_ports Ruleset#additional_cacheable_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalCacheablePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? AdditionalCacheablePorts
        {
            get;
            set;
        }

        private object? _algorithms;

        /// <summary>Custom order for compression algorithms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#algorithms Ruleset#algorithms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAlgorithms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Algorithms
        {
            get => _algorithms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersAlgorithms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersAlgorithms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _algorithms = value;
            }
        }

        /// <summary>The name of a custom asset to serve as the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#asset_name Ruleset#asset_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssetName
        {
            get;
            set;
        }

        private object? _automaticHttpsRewrites;

        /// <summary>Whether to enable Automatic HTTPS Rewrites.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#automatic_https_rewrites Ruleset#automatic_https_rewrites}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutomaticHttpsRewrites
        {
            get => _automaticHttpsRewrites;
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
                _automaticHttpsRewrites = value;
            }
        }

        /// <summary>Which file extensions to minify automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#autominify Ruleset#autominify}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autominify", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAutominify\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersAutominify? Autominify
        {
            get;
            set;
        }

        private object? _bic;

        /// <summary>Whether to enable Browser Integrity Check (BIC).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#bic Ruleset#bic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Bic
        {
            get => _bic;
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
                _bic = value;
            }
        }

        /// <summary>How long client browsers should cache the response.</summary>
        /// <remarks>
        /// Cloudflare cache purge will not purge content cached on client browsers, so high browser TTLs may lead to stale content.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#browser_ttl Ruleset#browser_ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "browserTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl? BrowserTtl
        {
            get;
            set;
        }

        private object? _cache;

        /// <summary>Whether the request's response from the origin is eligible for caching.</summary>
        /// <remarks>
        /// Caching itself will still depend on the cache control header and your other caching configurations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache Ruleset#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Cache
        {
            get => _cache;
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
                _cache = value;
            }
        }

        /// <summary>Which components of the request are included in or excluded from the cache key Cloudflare uses to store the response in cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_key Ruleset#cache_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKey\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey? CacheKey
        {
            get;
            set;
        }

        /// <summary>Settings to determine whether the request's response from origin is eligible for Cache Reserve (requires a Cache Reserve add-on plan).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cache_reserve Ruleset#cache_reserve}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheReserve", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheReserve\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve? CacheReserve
        {
            get;
            set;
        }

        /// <summary>The response content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#content Ruleset#content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }

        /// <summary>The content type header to set with the error response. Available values: "application/json", "text/html", "text/plain", "text/xml".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#content_type Ruleset#content_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }

        private object? _cookieFields;

        /// <summary>The cookie fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cookie_fields Ruleset#cookie_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookieFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCookieFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CookieFields
        {
            get => _cookieFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersCookieFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCookieFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cookieFields = value;
            }
        }

        private object? _disableApps;

        /// <summary>Whether to disable Cloudflare Apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#disable_apps Ruleset#disable_apps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableApps
        {
            get => _disableApps;
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
                _disableApps = value;
            }
        }

        private object? _disableRum;

        /// <summary>Whether to disable Real User Monitoring (RUM).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#disable_rum Ruleset#disable_rum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableRum", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableRum
        {
            get => _disableRum;
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
                _disableRum = value;
            }
        }

        private object? _disableZaraz;

        /// <summary>Whether to disable Zaraz.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#disable_zaraz Ruleset#disable_zaraz}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableZaraz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableZaraz
        {
            get => _disableZaraz;
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
                _disableZaraz = value;
            }
        }

        /// <summary>How long the Cloudflare edge network should cache the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#edge_ttl Ruleset#edge_ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "edgeTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl? EdgeTtl
        {
            get;
            set;
        }

        private object? _emailObfuscation;

        /// <summary>Whether to enable Email Obfuscation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#email_obfuscation Ruleset#email_obfuscation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailObfuscation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EmailObfuscation
        {
            get => _emailObfuscation;
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
                _emailObfuscation = value;
            }
        }

        /// <summary>An expression to generate cache tags for set_cache_tags action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#expression Ruleset#expression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        private object? _fonts;

        /// <summary>Whether to enable Cloudflare Fonts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#fonts Ruleset#fonts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fonts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Fonts
        {
            get => _fonts;
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
                _fonts = value;
            }
        }

        /// <summary>A redirect based on a bulk list lookup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#from_list Ruleset#from_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromList", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromListStruct\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersFromListStruct? FromList
        {
            get;
            set;
        }

        /// <summary>A redirect based on the request properties.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#from_value Ruleset#from_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromValue", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValue\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersFromValue? FromValue
        {
            get;
            set;
        }

        private object? _headers;

        /// <summary>A map of headers to rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#headers Ruleset#headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.Ruleset.IRulesetRulesActionParametersHeaders> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersHeaders).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        /// <summary>A value to rewrite the HTTP host header to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#host_header Ruleset#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostHeader
        {
            get;
            set;
        }

        private object? _hotlinkProtection;

        /// <summary>Whether to enable Hotlink Protection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#hotlink_protection Ruleset#hotlink_protection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hotlinkProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HotlinkProtection
        {
            get => _hotlinkProtection;
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
                _hotlinkProtection = value;
            }
        }

        /// <summary>The ID of the ruleset to execute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#id Ruleset#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Set the immutable cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#immutable Ruleset#immutable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "immutable", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersImmutable\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersImmutable? Immutable
        {
            get;
            set;
        }

        /// <summary>A delta to change the score by, which can be either positive or negative.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#increment Ruleset#increment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "increment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Increment
        {
            get;
            set;
        }

        /// <summary>The configuration to use for matched data logging.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#matched_data Ruleset#matched_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchedData", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMatchedData\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData? MatchedData
        {
            get;
            set;
        }

        /// <summary>Set the max-age cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#max_age Ruleset#max_age}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMaxAge\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersMaxAge? MaxAge
        {
            get;
            set;
        }

        private object? _mirage;

        /// <summary>Whether to enable Mirage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#mirage Ruleset#mirage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mirage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Mirage
        {
            get => _mirage;
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
                _mirage = value;
            }
        }

        /// <summary>Set the must-revalidate cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#must_revalidate Ruleset#must_revalidate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mustRevalidate", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMustRevalidate\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersMustRevalidate? MustRevalidate
        {
            get;
            set;
        }

        /// <summary>Set the must-understand cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#must_understand Ruleset#must_understand}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mustUnderstand", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMustUnderstand\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersMustUnderstand? MustUnderstand
        {
            get;
            set;
        }

        /// <summary>Set the no-cache cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#no_cache Ruleset#no_cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noCache", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersNoCache\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersNoCache? NoCache
        {
            get;
            set;
        }

        /// <summary>Set the no-store cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#no_store Ruleset#no_store}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noStore", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersNoStore\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersNoStore? NoStore
        {
            get;
            set;
        }

        /// <summary>Set the no-transform cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#no_transform Ruleset#no_transform}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noTransform", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersNoTransform\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersNoTransform? NoTransform
        {
            get;
            set;
        }

        /// <summary>The operation to perform for set_cache_tags action. Available values: "set", "add", "remove".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#operation Ruleset#operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operation
        {
            get;
            set;
        }

        private object? _opportunisticEncryption;

        /// <summary>Whether to enable Opportunistic Encryption.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#opportunistic_encryption Ruleset#opportunistic_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OpportunisticEncryption
        {
            get => _opportunisticEncryption;
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
                _opportunisticEncryption = value;
            }
        }

        /// <summary>An origin to route to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#origin Ruleset#origin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOrigin\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersOrigin? Origin
        {
            get;
            set;
        }

        private object? _originCacheControl;

        /// <summary>Whether Cloudflare will aim to strictly adhere to RFC 7234.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#origin_cache_control Ruleset#origin_cache_control}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originCacheControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OriginCacheControl
        {
            get => _originCacheControl;
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
                _originCacheControl = value;
            }
        }

        private object? _originErrorPagePassthru;

        /// <summary>Whether to generate Cloudflare error pages for issues from the origin server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#origin_error_page_passthru Ruleset#origin_error_page_passthru}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originErrorPagePassthru", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OriginErrorPagePassthru
        {
            get => _originErrorPagePassthru;
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
                _originErrorPagePassthru = value;
            }
        }

        /// <summary>A set of overrides to apply to the target ruleset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#overrides Ruleset#overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverrides\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersOverrides? Overrides
        {
            get;
            set;
        }

        /// <summary>A list of phases to skip the execution of.</summary>
        /// <remarks>
        /// This option is incompatible with the rulesets option.
        /// Available values: "ddos_l4", "ddos_l7", "http_config_settings", "http_custom_errors", "http_log_custom_fields", "http_ratelimit", "http_request_cache_settings", "http_request_dynamic_redirect", "http_request_firewall_custom", "http_request_firewall_managed", "http_request_late_transform", "http_request_origin", "http_request_redirect", "http_request_sanitize", "http_request_sbfm", "http_request_transform", "http_response_cache_settings", "http_response_compression", "http_response_firewall_managed", "http_response_headers_transform", "magic_transit", "magic_transit_ids_managed", "magic_transit_managed", "magic_transit_ratelimit".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#phases Ruleset#phases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Phases
        {
            get;
            set;
        }

        /// <summary>The Polish level to configure. Available values: "off", "lossless", "lossy", "webp".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#polish Ruleset#polish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Polish
        {
            get;
            set;
        }

        /// <summary>Set the private cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#private Ruleset#private}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "private", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersPrivate\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersPrivate? Private
        {
            get;
            set;
        }

        /// <summary>A list of legacy security products to skip the execution of. Available values: "bic", "hot", "rateLimit", "securityLevel", "uaBlock", "waf", "zoneLockdown".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#products Ruleset#products}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Products
        {
            get;
            set;
        }

        /// <summary>Set the proxy-revalidate cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#proxy_revalidate Ruleset#proxy_revalidate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyRevalidate", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersProxyRevalidate\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersProxyRevalidate? ProxyRevalidate
        {
            get;
            set;
        }

        /// <summary>Set the public cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#public Ruleset#public}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "public", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersPublic\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersPublic? Public
        {
            get;
            set;
        }

        private object? _rawResponseFields;

        /// <summary>The raw response fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#raw_response_fields Ruleset#raw_response_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rawResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRawResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RawResponseFields
        {
            get => _rawResponseFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersRawResponseFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersRawResponseFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rawResponseFields = value;
            }
        }

        /// <summary>A timeout value between two successive read operations to use for your origin server.</summary>
        /// <remarks>
        /// Historically, the timeout value between two read options from Cloudflare to an origin server is 100 seconds. If you are attempting to reduce HTTP 524 errors because of timeouts from an origin server, try increasing this timeout value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#read_timeout Ruleset#read_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadTimeout
        {
            get;
            set;
        }

        /// <summary>The request body buffering mode to configure. Available values: "none", "standard", "full".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#request_body_buffering Ruleset#request_body_buffering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBodyBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestBodyBuffering
        {
            get;
            set;
        }

        private object? _requestFields;

        /// <summary>The raw request fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#request_fields Ruleset#request_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestFields
        {
            get => _requestFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersRequestFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersRequestFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestFields = value;
            }
        }

        private object? _respectStrongEtags;

        /// <summary>Whether Cloudflare should respect strong ETag (entity tag) headers.</summary>
        /// <remarks>
        /// If false, Cloudflare converts strong ETag headers to weak ETag headers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#respect_strong_etags Ruleset#respect_strong_etags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "respectStrongEtags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RespectStrongEtags
        {
            get => _respectStrongEtags;
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
                _respectStrongEtags = value;
            }
        }

        /// <summary>The response to show when the block is applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#response Ruleset#response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponse\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersResponse? Response
        {
            get;
            set;
        }

        /// <summary>The response body buffering mode to configure. Available values: "none", "standard".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#response_body_buffering Ruleset#response_body_buffering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseBodyBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseBodyBuffering
        {
            get;
            set;
        }

        private object? _responseFields;

        /// <summary>The transformed response fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#response_fields Ruleset#response_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseFields
        {
            get => _responseFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersResponseFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersResponseFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseFields = value;
            }
        }

        private object? _rocketLoader;

        /// <summary>Whether to enable Rocket Loader.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#rocket_loader Ruleset#rocket_loader}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rocketLoader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RocketLoader
        {
            get => _rocketLoader;
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
                _rocketLoader = value;
            }
        }

        private object? _rules;

        /// <summary>A mapping of ruleset IDs to a list of rule IDs in that ruleset to skip the execution of.</summary>
        /// <remarks>
        /// This option is incompatible with the ruleset option.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#rules Ruleset#rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }

        /// <summary>A ruleset to skip the execution of. This option is incompatible with the rulesets option. Available values: "current".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#ruleset Ruleset#ruleset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ruleset
        {
            get;
            set;
        }

        /// <summary>A list of ruleset IDs to skip the execution of.</summary>
        /// <remarks>
        /// This option is incompatible with the ruleset and phases options.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#rulesets Ruleset#rulesets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rulesets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Rulesets
        {
            get;
            set;
        }

        /// <summary>The Security Level to configure. Available values: "off", "essentially_off", "low", "medium", "high", "under_attack".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#security_level Ruleset#security_level}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityLevel
        {
            get;
            set;
        }

        private object? _serverSideExcludes;

        /// <summary>Whether to enable Server-Side Excludes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#server_side_excludes Ruleset#server_side_excludes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideExcludes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ServerSideExcludes
        {
            get => _serverSideExcludes;
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
                _serverSideExcludes = value;
            }
        }

        /// <summary>When to serve stale content from cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#serve_stale Ruleset#serve_stale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serveStale", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersServeStale\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersServeStale? ServeStale
        {
            get;
            set;
        }

        /// <summary>Set the s-maxage cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#s_maxage Ruleset#s_maxage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sMaxage", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersSMaxage\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersSMaxage? SMaxage
        {
            get;
            set;
        }

        /// <summary>A Server Name Indication (SNI) override.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#sni Ruleset#sni}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sni", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersSni\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersSni? Sni
        {
            get;
            set;
        }

        /// <summary>The SSL level to configure. Available values: "off", "flexible", "full", "strict", "origin_pull".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#ssl Ruleset#ssl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ssl
        {
            get;
            set;
        }

        /// <summary>Set the stale-if-error cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#stale_if_error Ruleset#stale_if_error}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staleIfError", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersStaleIfError\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersStaleIfError? StaleIfError
        {
            get;
            set;
        }

        /// <summary>Set the stale-while-revalidate cache control directive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#stale_while_revalidate Ruleset#stale_while_revalidate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staleWhileRevalidate", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersStaleWhileRevalidate\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersStaleWhileRevalidate? StaleWhileRevalidate
        {
            get;
            set;
        }

        /// <summary>The status code to use for the error.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#status_code Ruleset#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StatusCode
        {
            get;
            set;
        }

        private object? _stripEtags;

        /// <summary>Whether to strip the ETag header from the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#strip_etags Ruleset#strip_etags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripEtags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StripEtags
        {
            get => _stripEtags;
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
                _stripEtags = value;
            }
        }

        private object? _stripLastModified;

        /// <summary>Whether to strip the Last-Modified header from the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#strip_last_modified Ruleset#strip_last_modified}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripLastModified", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StripLastModified
        {
            get => _stripLastModified;
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
                _stripLastModified = value;
            }
        }

        private object? _stripSetCookie;

        /// <summary>Whether to strip the Set-Cookie header from the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#strip_set_cookie Ruleset#strip_set_cookie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripSetCookie", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StripSetCookie
        {
            get => _stripSetCookie;
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
                _stripSetCookie = value;
            }
        }

        private object? _sxg;

        /// <summary>Whether to enable Signed Exchanges (SXG).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#sxg Ruleset#sxg}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sxg", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Sxg
        {
            get => _sxg;
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
                _sxg = value;
            }
        }

        private object? _transformedRequestFields;

        /// <summary>The transformed request fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#transformed_request_fields Ruleset#transformed_request_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformedRequestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersTransformedRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransformedRequestFields
        {
            get => _transformedRequestFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersTransformedRequestFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersTransformedRequestFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformedRequestFields = value;
            }
        }

        /// <summary>A URI rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#uri Ruleset#uri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUri\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersUri? Uri
        {
            get;
            set;
        }

        /// <summary>The cache tag values for set_cache_tags action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#values Ruleset#values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
