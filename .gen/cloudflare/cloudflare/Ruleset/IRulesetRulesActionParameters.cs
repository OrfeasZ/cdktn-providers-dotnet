using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParameters), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParameters")]
    public interface IRulesetRulesActionParameters
    {
        /// <summary>List of additional ports that caching can be enabled on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#additional_cacheable_ports Ruleset#additional_cacheable_ports}
        /// </remarks>
        [JsiiProperty(name: "additionalCacheablePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? AdditionalCacheablePorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom order for compression algorithms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#algorithms Ruleset#algorithms}
        /// </remarks>
        [JsiiProperty(name: "algorithms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAlgorithms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Algorithms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Automatic HTTPS Rewrites.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#automatic_https_rewrites Ruleset#automatic_https_rewrites}
        /// </remarks>
        [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutomaticHttpsRewrites
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select which file extensions to minify automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#autominify Ruleset#autominify}
        /// </remarks>
        [JsiiProperty(name: "autominify", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAutominify\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersAutominify? Autominify
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Browser Integrity Check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#bic Ruleset#bic}
        /// </remarks>
        [JsiiProperty(name: "bic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify how long client browsers should cache the response.</summary>
        /// <remarks>
        /// Cloudflare cache purge will not purge content cached on client browsers, so high browser TTLs may lead to stale content.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#browser_ttl Ruleset#browser_ttl}
        /// </remarks>
        [JsiiProperty(name: "browserTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl? BrowserTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mark whether the request’s response from origin is eligible for caching.</summary>
        /// <remarks>
        /// Caching itself will still depend on the cache-control header and your other caching configurations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache Ruleset#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define which components of the request are included or excluded from the cache key Cloudflare uses to store the response in cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache_key Ruleset#cache_key}
        /// </remarks>
        [JsiiProperty(name: "cacheKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey? CacheKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mark whether the request's response from origin is eligible for Cache Reserve (requires a Cache Reserve add-on plan).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache_reserve Ruleset#cache_reserve}
        /// </remarks>
        [JsiiProperty(name: "cacheReserve", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheReserve\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve? CacheReserve
        {
            get
            {
                return null;
            }
        }

        /// <summary>Error response content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#content Ruleset#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Content-type header to set with the response. Available values: "application/json", "text/xml", "text/plain", "text/html".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#content_type Ruleset#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cookie fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cookie_fields Ruleset#cookie_fields}
        /// </remarks>
        [JsiiProperty(name: "cookieFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCookieFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CookieFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn off all active Cloudflare Apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_apps Ruleset#disable_apps}
        /// </remarks>
        [JsiiProperty(name: "disableApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn off Real User Monitoring (RUM).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_rum Ruleset#disable_rum}
        /// </remarks>
        [JsiiProperty(name: "disableRum", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableRum
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn off Zaraz.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_zaraz Ruleset#disable_zaraz}
        /// </remarks>
        [JsiiProperty(name: "disableZaraz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableZaraz
        {
            get
            {
                return null;
            }
        }

        /// <summary>TTL (Time to Live) specifies the maximum time to cache a resource in the Cloudflare edge network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#edge_ttl Ruleset#edge_ttl}
        /// </remarks>
        [JsiiProperty(name: "edgeTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl? EdgeTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Email Obfuscation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#email_obfuscation Ruleset#email_obfuscation}
        /// </remarks>
        [JsiiProperty(name: "emailObfuscation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmailObfuscation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Cloudflare Fonts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#fonts Ruleset#fonts}
        /// </remarks>
        [JsiiProperty(name: "fonts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Fonts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Serve a redirect based on a bulk list lookup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#from_list Ruleset#from_list}
        /// </remarks>
        [JsiiProperty(name: "fromList", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersFromListStruct? FromList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Serve a redirect based on the request properties.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#from_value Ruleset#from_value}
        /// </remarks>
        [JsiiProperty(name: "fromValue", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersFromValue? FromValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Map of request headers to modify.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#headers Ruleset#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rewrite the HTTP Host header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#host_header Ruleset#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off the Hotlink Protection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#hotlink_protection Ruleset#hotlink_protection}
        /// </remarks>
        [JsiiProperty(name: "hotlinkProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HotlinkProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the ruleset to execute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#id Ruleset#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Increment contains the delta to change the score and can be either positive or negative.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#increment Ruleset#increment}
        /// </remarks>
        [JsiiProperty(name: "increment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Increment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The configuration to use for matched data logging.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#matched_data Ruleset#matched_data}
        /// </remarks>
        [JsiiProperty(name: "matchedData", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMatchedData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData? MatchedData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Mirage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#mirage Ruleset#mirage}
        /// </remarks>
        [JsiiProperty(name: "mirage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Mirage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Opportunistic Encryption.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#opportunistic_encryption Ruleset#opportunistic_encryption}
        /// </remarks>
        [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpportunisticEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Override the IP/TCP destination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin Ruleset#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOrigin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersOrigin? Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, Cloudflare will aim to strictly adhere to RFC 7234.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin_cache_control Ruleset#origin_cache_control}
        /// </remarks>
        [JsiiProperty(name: "originCacheControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginCacheControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Generate Cloudflare error pages from issues sent from the origin server.</summary>
        /// <remarks>
        /// When on, error pages will trigger for issues from the origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin_error_page_passthru Ruleset#origin_error_page_passthru}
        /// </remarks>
        [JsiiProperty(name: "originErrorPagePassthru", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginErrorPagePassthru
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of overrides to apply to the target ruleset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#overrides Ruleset#overrides}
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverrides\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersOverrides? Overrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of phases to skip the execution of. This option is incompatible with the rulesets option.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#phases Ruleset#phases}
        /// </remarks>
        [JsiiProperty(name: "phases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Phases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure the Polish level. Available values: "off", "lossless", "lossy", "webp".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#polish Ruleset#polish}
        /// </remarks>
        [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Polish
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of legacy security products to skip the execution of.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#products Ruleset#products}
        /// </remarks>
        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Products
        {
            get
            {
                return null;
            }
        }

        /// <summary>The raw response fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#raw_response_fields Ruleset#raw_response_fields}
        /// </remarks>
        [JsiiProperty(name: "rawResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRawResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RawResponseFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define a timeout value between two successive read operations to your origin server.</summary>
        /// <remarks>
        /// Historically, the timeout value between two read options from Cloudflare to an origin server is 100 seconds. If you are attempting to reduce HTTP 524 errors because of timeouts from an origin server, try increasing this timeout value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#read_timeout Ruleset#read_timeout}
        /// </remarks>
        [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>The raw request fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#request_fields Ruleset#request_fields}
        /// </remarks>
        [JsiiProperty(name: "requestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify whether or not Cloudflare should respect strong ETag (entity tag) headers.</summary>
        /// <remarks>
        /// When off, Cloudflare converts strong ETag headers to weak ETag headers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#respect_strong_etags Ruleset#respect_strong_etags}
        /// </remarks>
        [JsiiProperty(name: "respectStrongEtags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RespectStrongEtags
        {
            get
            {
                return null;
            }
        }

        /// <summary>The response to show when the block is applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#response Ruleset#response}
        /// </remarks>
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersResponse? Response
        {
            get
            {
                return null;
            }
        }

        /// <summary>The transformed response fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#response_fields Ruleset#response_fields}
        /// </remarks>
        [JsiiProperty(name: "responseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResponseFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Rocket Loader.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rocket_loader Ruleset#rocket_loader}
        /// </remarks>
        [JsiiProperty(name: "rocketLoader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RocketLoader
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of ruleset IDs to a list of rule IDs in that ruleset to skip the execution of.</summary>
        /// <remarks>
        /// This option is incompatible with the ruleset option.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rules Ruleset#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>A ruleset to skip the execution of. This option is incompatible with the rulesets option. Available values: "current".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ruleset Ruleset#ruleset}
        /// </remarks>
        [JsiiProperty(name: "ruleset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ruleset
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of ruleset IDs to skip the execution of.</summary>
        /// <remarks>
        /// This option is incompatible with the ruleset and phases options.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rulesets Ruleset#rulesets}
        /// </remarks>
        [JsiiProperty(name: "rulesets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Rulesets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure the Security Level. Available values: "off", "essentially_off", "low", "medium", "high", "under_attack".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#security_level Ruleset#security_level}
        /// </remarks>
        [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Server Side Excludes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#server_side_excludes Ruleset#server_side_excludes}
        /// </remarks>
        [JsiiProperty(name: "serverSideExcludes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerSideExcludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define if Cloudflare should serve stale content while getting the latest content from the origin.</summary>
        /// <remarks>
        /// If on, Cloudflare will not serve stale content while getting the latest content from the origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#serve_stale Ruleset#serve_stale}
        /// </remarks>
        [JsiiProperty(name: "serveStale", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersServeStale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersServeStale? ServeStale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Override the Server Name Indication (SNI).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#sni Ruleset#sni}
        /// </remarks>
        [JsiiProperty(name: "sni", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersSni\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersSni? Sni
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure the SSL level. Available values: "off", "flexible", "full", "strict", "origin_pull".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ssl Ruleset#ssl}
        /// </remarks>
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ssl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The status code to use for the error.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#status_code Ruleset#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StatusCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Turn on or off Signed Exchanges (SXG).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#sxg Ruleset#sxg}
        /// </remarks>
        [JsiiProperty(name: "sxg", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sxg
        {
            get
            {
                return null;
            }
        }

        /// <summary>The transformed request fields to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#transformed_request_fields Ruleset#transformed_request_fields}
        /// </remarks>
        [JsiiProperty(name: "transformedRequestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersTransformedRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformedRequestFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>URI to rewrite the request to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#uri Ruleset#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUri\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersUri? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParameters), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParameters")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of additional ports that caching can be enabled on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#additional_cacheable_ports Ruleset#additional_cacheable_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalCacheablePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? AdditionalCacheablePorts
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Custom order for compression algorithms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#algorithms Ruleset#algorithms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "algorithms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAlgorithms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Algorithms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn on or off Automatic HTTPS Rewrites.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#automatic_https_rewrites Ruleset#automatic_https_rewrites}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticHttpsRewrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutomaticHttpsRewrites
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Select which file extensions to minify automatically.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#autominify Ruleset#autominify}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autominify", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersAutominify\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersAutominify? Autominify
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersAutominify?>();
            }

            /// <summary>Turn on or off Browser Integrity Check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#bic Ruleset#bic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Bic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify how long client browsers should cache the response.</summary>
            /// <remarks>
            /// Cloudflare cache purge will not purge content cached on client browsers, so high browser TTLs may lead to stale content.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#browser_ttl Ruleset#browser_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browserTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl? BrowserTtl
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl?>();
            }

            /// <summary>Mark whether the request’s response from origin is eligible for caching.</summary>
            /// <remarks>
            /// Caching itself will still depend on the cache-control header and your other caching configurations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache Ruleset#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Cache
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Define which components of the request are included or excluded from the cache key Cloudflare uses to store the response in cache.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache_key Ruleset#cache_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheKey", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKey\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey? CacheKey
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheKey?>();
            }

            /// <summary>Mark whether the request's response from origin is eligible for Cache Reserve (requires a Cache Reserve add-on plan).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cache_reserve Ruleset#cache_reserve}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheReserve", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheReserve\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve? CacheReserve
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve?>();
            }

            /// <summary>Error response content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#content Ruleset#content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Content-type header to set with the response. Available values: "application/json", "text/xml", "text/plain", "text/html".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#content_type Ruleset#content_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The cookie fields to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#cookie_fields Ruleset#cookie_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookieFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCookieFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CookieFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn off all active Cloudflare Apps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_apps Ruleset#disable_apps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableApps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn off Real User Monitoring (RUM).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_rum Ruleset#disable_rum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableRum", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableRum
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn off Zaraz.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_zaraz Ruleset#disable_zaraz}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableZaraz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableZaraz
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>TTL (Time to Live) specifies the maximum time to cache a resource in the Cloudflare edge network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#edge_ttl Ruleset#edge_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "edgeTtl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl? EdgeTtl
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl?>();
            }

            /// <summary>Turn on or off Email Obfuscation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#email_obfuscation Ruleset#email_obfuscation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailObfuscation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EmailObfuscation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn on or off Cloudflare Fonts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#fonts Ruleset#fonts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fonts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Fonts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Serve a redirect based on a bulk list lookup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#from_list Ruleset#from_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fromList", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromListStruct\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersFromListStruct? FromList
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersFromListStruct?>();
            }

            /// <summary>Serve a redirect based on the request properties.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#from_value Ruleset#from_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fromValue", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValue\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersFromValue? FromValue
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersFromValue?>();
            }

            /// <summary>Map of request headers to modify.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#headers Ruleset#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Rewrite the HTTP Host header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#host_header Ruleset#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Turn on or off the Hotlink Protection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#hotlink_protection Ruleset#hotlink_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hotlinkProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HotlinkProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the ruleset to execute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#id Ruleset#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Increment contains the delta to change the score and can be either positive or negative.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#increment Ruleset#increment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "increment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Increment
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The configuration to use for matched data logging.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#matched_data Ruleset#matched_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchedData", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersMatchedData\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData? MatchedData
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData?>();
            }

            /// <summary>Turn on or off Mirage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#mirage Ruleset#mirage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mirage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Mirage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn on or off Opportunistic Encryption.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#opportunistic_encryption Ruleset#opportunistic_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opportunisticEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OpportunisticEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Override the IP/TCP destination.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin Ruleset#origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOrigin\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersOrigin? Origin
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersOrigin?>();
            }

            /// <summary>When enabled, Cloudflare will aim to strictly adhere to RFC 7234.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin_cache_control Ruleset#origin_cache_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originCacheControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OriginCacheControl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Generate Cloudflare error pages from issues sent from the origin server.</summary>
            /// <remarks>
            /// When on, error pages will trigger for issues from the origin.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#origin_error_page_passthru Ruleset#origin_error_page_passthru}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originErrorPagePassthru", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OriginErrorPagePassthru
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A set of overrides to apply to the target ruleset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#overrides Ruleset#overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverrides\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersOverrides? Overrides
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersOverrides?>();
            }

            /// <summary>A list of phases to skip the execution of. This option is incompatible with the rulesets option.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#phases Ruleset#phases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Phases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Configure the Polish level. Available values: "off", "lossless", "lossy", "webp".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#polish Ruleset#polish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "polish", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Polish
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of legacy security products to skip the execution of.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#products Ruleset#products}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Products
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The raw response fields to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#raw_response_fields Ruleset#raw_response_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rawResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRawResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RawResponseFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Define a timeout value between two successive read operations to your origin server.</summary>
            /// <remarks>
            /// Historically, the timeout value between two read options from Cloudflare to an origin server is 100 seconds. If you are attempting to reduce HTTP 524 errors because of timeouts from an origin server, try increasing this timeout value.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#read_timeout Ruleset#read_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The raw request fields to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#request_fields Ruleset#request_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify whether or not Cloudflare should respect strong ETag (entity tag) headers.</summary>
            /// <remarks>
            /// When off, Cloudflare converts strong ETag headers to weak ETag headers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#respect_strong_etags Ruleset#respect_strong_etags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "respectStrongEtags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RespectStrongEtags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The response to show when the block is applied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#response Ruleset#response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponse\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersResponse? Response
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersResponse?>();
            }

            /// <summary>The transformed response fields to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#response_fields Ruleset#response_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResponseFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Turn on or off Rocket Loader.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rocket_loader Ruleset#rocket_loader}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rocketLoader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RocketLoader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A mapping of ruleset IDs to a list of rule IDs in that ruleset to skip the execution of.</summary>
            /// <remarks>
            /// This option is incompatible with the ruleset option.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rules Ruleset#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A ruleset to skip the execution of. This option is incompatible with the rulesets option. Available values: "current".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ruleset Ruleset#ruleset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ruleset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of ruleset IDs to skip the execution of.</summary>
            /// <remarks>
            /// This option is incompatible with the ruleset and phases options.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#rulesets Ruleset#rulesets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rulesets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Rulesets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Configure the Security Level. Available values: "off", "essentially_off", "low", "medium", "high", "under_attack".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#security_level Ruleset#security_level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Turn on or off Server Side Excludes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#server_side_excludes Ruleset#server_side_excludes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverSideExcludes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ServerSideExcludes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Define if Cloudflare should serve stale content while getting the latest content from the origin.</summary>
            /// <remarks>
            /// If on, Cloudflare will not serve stale content while getting the latest content from the origin.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#serve_stale Ruleset#serve_stale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serveStale", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersServeStale\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersServeStale? ServeStale
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersServeStale?>();
            }

            /// <summary>Override the Server Name Indication (SNI).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#sni Ruleset#sni}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sni", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersSni\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersSni? Sni
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersSni?>();
            }

            /// <summary>Configure the SSL level. Available values: "off", "flexible", "full", "strict", "origin_pull".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ssl Ruleset#ssl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ssl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The status code to use for the error.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#status_code Ruleset#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StatusCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Turn on or off Signed Exchanges (SXG).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#sxg Ruleset#sxg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sxg", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sxg
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The transformed request fields to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#transformed_request_fields Ruleset#transformed_request_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformedRequestFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersTransformedRequestFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformedRequestFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URI to rewrite the request to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#uri Ruleset#uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUri\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersUri? Uri
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersUri?>();
            }
        }
    }
}
