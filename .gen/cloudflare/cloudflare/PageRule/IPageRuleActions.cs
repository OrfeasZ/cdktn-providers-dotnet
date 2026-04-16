using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiInterface(nativeType: typeof(IPageRuleActions), fullyQualifiedName: "cloudflare.pageRule.PageRuleActions")]
    public interface IPageRuleActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#always_use_https PageRule#always_use_https}.</summary>
        [JsiiProperty(name: "alwaysUseHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlwaysUseHttps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#automatic_https_rewrites PageRule#automatic_https_rewrites}.</summary>
        [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutomaticHttpsRewrites
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_cache_ttl PageRule#browser_cache_ttl}.</summary>
        [JsiiProperty(name: "browserCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BrowserCacheTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_check PageRule#browser_check}.</summary>
        [JsiiProperty(name: "browserCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BrowserCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#bypass_cache_on_cookie PageRule#bypass_cache_on_cookie}.</summary>
        [JsiiProperty(name: "bypassCacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BypassCacheOnCookie
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_by_device_type PageRule#cache_by_device_type}.</summary>
        [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheByDeviceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_deception_armor PageRule#cache_deception_armor}.</summary>
        [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheDeceptionArmor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_key_fields PageRule#cache_key_fields}.</summary>
        [JsiiProperty(name: "cacheKeyFields", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFields\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFields? CacheKeyFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_level PageRule#cache_level}.</summary>
        [JsiiProperty(name: "cacheLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_on_cookie PageRule#cache_on_cookie}.</summary>
        [JsiiProperty(name: "cacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheOnCookie
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_ttl_by_status PageRule#cache_ttl_by_status}.</summary>
        [JsiiProperty(name: "cacheTtlByStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CacheTtlByStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_apps PageRule#disable_apps}.</summary>
        [JsiiProperty(name: "disableApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_performance PageRule#disable_performance}.</summary>
        [JsiiProperty(name: "disablePerformance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisablePerformance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_security PageRule#disable_security}.</summary>
        [JsiiProperty(name: "disableSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableSecurity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_zaraz PageRule#disable_zaraz}.</summary>
        [JsiiProperty(name: "disableZaraz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableZaraz
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#edge_cache_ttl PageRule#edge_cache_ttl}.</summary>
        [JsiiProperty(name: "edgeCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EdgeCacheTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#email_obfuscation PageRule#email_obfuscation}.</summary>
        [JsiiProperty(name: "emailObfuscation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailObfuscation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#explicit_cache_control PageRule#explicit_cache_control}.</summary>
        [JsiiProperty(name: "explicitCacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExplicitCacheControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#forwarding_url PageRule#forwarding_url}.</summary>
        [JsiiProperty(name: "forwardingUrl", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsForwardingUrl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsForwardingUrl? ForwardingUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#host_header_override PageRule#host_header_override}.</summary>
        [JsiiProperty(name: "hostHeaderOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostHeaderOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ip_geolocation PageRule#ip_geolocation}.</summary>
        [JsiiProperty(name: "ipGeolocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpGeolocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#mirage PageRule#mirage}.</summary>
        [JsiiProperty(name: "mirage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mirage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#opportunistic_encryption PageRule#opportunistic_encryption}.</summary>
        [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpportunisticEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#origin_error_page_pass_thru PageRule#origin_error_page_pass_thru}.</summary>
        [JsiiProperty(name: "originErrorPagePassThru", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginErrorPagePassThru
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#polish PageRule#polish}.</summary>
        [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Polish
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#resolve_override PageRule#resolve_override}.</summary>
        [JsiiProperty(name: "resolveOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResolveOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#respect_strong_etag PageRule#respect_strong_etag}.</summary>
        [JsiiProperty(name: "respectStrongEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RespectStrongEtag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#response_buffering PageRule#response_buffering}.</summary>
        [JsiiProperty(name: "responseBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseBuffering
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#rocket_loader PageRule#rocket_loader}.</summary>
        [JsiiProperty(name: "rocketLoader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RocketLoader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#security_level PageRule#security_level}.</summary>
        [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#sort_query_string_for_cache PageRule#sort_query_string_for_cache}.</summary>
        [JsiiProperty(name: "sortQueryStringForCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortQueryStringForCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ssl PageRule#ssl}.</summary>
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ssl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#true_client_ip_header PageRule#true_client_ip_header}.</summary>
        [JsiiProperty(name: "trueClientIpHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrueClientIpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#waf PageRule#waf}.</summary>
        [JsiiProperty(name: "waf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Waf
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPageRuleActions), fullyQualifiedName: "cloudflare.pageRule.PageRuleActions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PageRule.IPageRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#always_use_https PageRule#always_use_https}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysUseHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AlwaysUseHttps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#automatic_https_rewrites PageRule#automatic_https_rewrites}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutomaticHttpsRewrites
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_cache_ttl PageRule#browser_cache_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "browserCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BrowserCacheTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#browser_check PageRule#browser_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "browserCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BrowserCheck
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#bypass_cache_on_cookie PageRule#bypass_cache_on_cookie}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bypassCacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BypassCacheOnCookie
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_by_device_type PageRule#cache_by_device_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheByDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheByDeviceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_deception_armor PageRule#cache_deception_armor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheDeceptionArmor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheDeceptionArmor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_key_fields PageRule#cache_key_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheKeyFields", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFields\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFields? CacheKeyFields
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFields?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_level PageRule#cache_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_on_cookie PageRule#cache_on_cookie}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheOnCookie", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheOnCookie
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cache_ttl_by_status PageRule#cache_ttl_by_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheTtlByStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CacheTtlByStatus
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_apps PageRule#disable_apps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableApps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_performance PageRule#disable_performance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disablePerformance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisablePerformance
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_security PageRule#disable_security}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableSecurity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#disable_zaraz PageRule#disable_zaraz}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableZaraz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableZaraz
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#edge_cache_ttl PageRule#edge_cache_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "edgeCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EdgeCacheTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#email_obfuscation PageRule#email_obfuscation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailObfuscation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailObfuscation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#explicit_cache_control PageRule#explicit_cache_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "explicitCacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExplicitCacheControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#forwarding_url PageRule#forwarding_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forwardingUrl", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsForwardingUrl\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsForwardingUrl? ForwardingUrl
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsForwardingUrl?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#host_header_override PageRule#host_header_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeaderOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostHeaderOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ip_geolocation PageRule#ip_geolocation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipGeolocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpGeolocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#mirage PageRule#mirage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mirage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mirage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#opportunistic_encryption PageRule#opportunistic_encryption}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpportunisticEncryption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#origin_error_page_pass_thru PageRule#origin_error_page_pass_thru}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originErrorPagePassThru", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginErrorPagePassThru
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#polish PageRule#polish}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Polish
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#resolve_override PageRule#resolve_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resolveOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResolveOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#respect_strong_etag PageRule#respect_strong_etag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "respectStrongEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RespectStrongEtag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#response_buffering PageRule#response_buffering}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseBuffering
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#rocket_loader PageRule#rocket_loader}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rocketLoader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RocketLoader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#security_level PageRule#security_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#sort_query_string_for_cache PageRule#sort_query_string_for_cache}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sortQueryStringForCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortQueryStringForCache
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#ssl PageRule#ssl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ssl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#true_client_ip_header PageRule#true_client_ip_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trueClientIpHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrueClientIpHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#waf PageRule#waf}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Waf
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
