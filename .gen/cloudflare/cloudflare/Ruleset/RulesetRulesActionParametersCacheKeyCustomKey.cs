using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKey")]
    public class RulesetRulesActionParametersCacheKeyCustomKey : cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey
    {
        /// <summary>Which cookies to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#cookie Ruleset#cookie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyCookie? Cookie
        {
            get;
            set;
        }

        /// <summary>Which headers to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#header Ruleset#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHeader? Header
        {
            get;
            set;
        }

        /// <summary>How to use the host in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#host Ruleset#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHost\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHost? Host
        {
            get;
            set;
        }

        /// <summary>Which query string parameters to include in or exclude from the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#query_string Ruleset#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString? QueryString
        {
            get;
            set;
        }

        /// <summary>How to use characteristics of the request user agent in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#user Ruleset#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUser\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyUser? User
        {
            get;
            set;
        }
    }
}
