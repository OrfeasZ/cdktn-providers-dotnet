using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiByValue(fqn: "cloudflare.pageRule.PageRuleActions")]
    public class PageRuleActions : cloudflare.PageRule.IPageRuleActions
    {
        private object? _alwaysUseHttps;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#always_use_https PageRule#always_use_https}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alwaysUseHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AlwaysUseHttps
        {
            get => _alwaysUseHttps;
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
                _alwaysUseHttps = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#automatic_https_rewrites PageRule#automatic_https_rewrites}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutomaticHttpsRewrites
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_cache_ttl PageRule#browser_cache_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "browserCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BrowserCacheTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_check PageRule#browser_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "browserCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BrowserCheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#bypass_cache_on_cookie PageRule#bypass_cache_on_cookie}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassCacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BypassCacheOnCookie
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_by_device_type PageRule#cache_by_device_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheByDeviceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_deception_armor PageRule#cache_deception_armor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheDeceptionArmor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_key_fields PageRule#cache_key_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyFields", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFields\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFields? CacheKeyFields
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_level PageRule#cache_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_on_cookie PageRule#cache_on_cookie}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheOnCookie
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_ttl_by_status PageRule#cache_ttl_by_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheTtlByStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CacheTtlByStatus
        {
            get;
            set;
        }

        private object? _disableApps;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_apps PageRule#disable_apps}.</summary>
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

        private object? _disablePerformance;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_performance PageRule#disable_performance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disablePerformance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisablePerformance
        {
            get => _disablePerformance;
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
                _disablePerformance = value;
            }
        }

        private object? _disableSecurity;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_security PageRule#disable_security}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableSecurity
        {
            get => _disableSecurity;
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
                _disableSecurity = value;
            }
        }

        private object? _disableZaraz;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_zaraz PageRule#disable_zaraz}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#edge_cache_ttl PageRule#edge_cache_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EdgeCacheTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#email_obfuscation PageRule#email_obfuscation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailObfuscation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailObfuscation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#explicit_cache_control PageRule#explicit_cache_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "explicitCacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExplicitCacheControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#forwarding_url PageRule#forwarding_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forwardingUrl", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsForwardingUrl\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsForwardingUrl? ForwardingUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#host_header_override PageRule#host_header_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostHeaderOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ip_geolocation PageRule#ip_geolocation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipGeolocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpGeolocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#mirage PageRule#mirage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mirage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mirage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#opportunistic_encryption PageRule#opportunistic_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpportunisticEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#origin_error_page_pass_thru PageRule#origin_error_page_pass_thru}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originErrorPagePassThru", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginErrorPagePassThru
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#polish PageRule#polish}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Polish
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#resolve_override PageRule#resolve_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolveOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResolveOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#respect_strong_etag PageRule#respect_strong_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "respectStrongEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RespectStrongEtag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#response_buffering PageRule#response_buffering}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseBuffering
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#rocket_loader PageRule#rocket_loader}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rocketLoader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RocketLoader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#security_level PageRule#security_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#sort_query_string_for_cache PageRule#sort_query_string_for_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortQueryStringForCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortQueryStringForCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ssl PageRule#ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ssl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#true_client_ip_header PageRule#true_client_ip_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trueClientIpHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrueClientIpHeader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#waf PageRule#waf}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Waf
        {
            get;
            set;
        }
    }
}
