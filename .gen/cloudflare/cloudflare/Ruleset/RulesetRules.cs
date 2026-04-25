using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRules")]
    public class RulesetRules : cloudflare.Ruleset.IRulesetRules
    {
        /// <summary>The action to perform when the rule matches.</summary>
        /// <remarks>
        /// Available values: "block", "challenge", "compress_response", "ddos_dynamic", "execute", "force_connection_close", "js_challenge", "log", "log_custom_field", "managed_challenge", "redirect", "rewrite", "route", "score", "serve_error", "set_cache_control", "set_cache_settings", "set_cache_tags", "set_config", "skip".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>The expression defining which traffic will match the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#expression Ruleset#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>The parameters configuring the rule's action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action_parameters Ruleset#action_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParameters\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParameters? ActionParameters
        {
            get;
            set;
        }

        /// <summary>An informative description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#description Ruleset#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Whether the rule should be executed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#enabled Ruleset#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>Configuration for exposed credential checking.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exposed_credential_check Ruleset#exposed_credential_check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exposedCredentialCheck", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesExposedCredentialCheck\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck? ExposedCredentialCheck
        {
            get;
            set;
        }

        /// <summary>An object configuring the rule's logging behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#logging Ruleset#logging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesLogging\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesLogging? Logging
        {
            get;
            set;
        }

        /// <summary>An object configuring the rule's rate limit behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ratelimit Ruleset#ratelimit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ratelimit", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesRatelimit\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesRatelimit? Ratelimit
        {
            get;
            set;
        }

        /// <summary>The reference of the rule (the rule's ID by default).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ref Ruleset#ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ref
        {
            get;
            set;
        }
    }
}
