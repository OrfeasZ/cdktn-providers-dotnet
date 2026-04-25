using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRules), fullyQualifiedName: "cloudflare.ruleset.RulesetRules")]
    public interface IRulesetRules
    {
        /// <summary>The action to perform when the rule matches.</summary>
        /// <remarks>
        /// Available values: "block", "challenge", "compress_response", "ddos_dynamic", "execute", "force_connection_close", "js_challenge", "log", "log_custom_field", "managed_challenge", "redirect", "rewrite", "route", "score", "serve_error", "set_cache_control", "set_cache_settings", "set_cache_tags", "set_config", "skip".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>The expression defining which traffic will match the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#expression Ruleset#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>The parameters configuring the rule's action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action_parameters Ruleset#action_parameters}
        /// </remarks>
        [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParameters? ActionParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>An informative description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#description Ruleset#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the rule should be executed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#enabled Ruleset#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for exposed credential checking.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exposed_credential_check Ruleset#exposed_credential_check}
        /// </remarks>
        [JsiiProperty(name: "exposedCredentialCheck", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesExposedCredentialCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck? ExposedCredentialCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>An object configuring the rule's logging behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#logging Ruleset#logging}
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesLogging? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>An object configuring the rule's rate limit behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ratelimit Ruleset#ratelimit}
        /// </remarks>
        [JsiiProperty(name: "ratelimit", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesRatelimit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesRatelimit? Ratelimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>The reference of the rule (the rule's ID by default).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ref Ruleset#ref}
        /// </remarks>
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ref
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRules), fullyQualifiedName: "cloudflare.ruleset.RulesetRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action to perform when the rule matches.</summary>
            /// <remarks>
            /// Available values: "block", "challenge", "compress_response", "ddos_dynamic", "execute", "force_connection_close", "js_challenge", "log", "log_custom_field", "managed_challenge", "redirect", "rewrite", "route", "score", "serve_error", "set_cache_control", "set_cache_settings", "set_cache_tags", "set_config", "skip".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action Ruleset#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The expression defining which traffic will match the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#expression Ruleset#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The parameters configuring the rule's action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action_parameters Ruleset#action_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParameters\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParameters? ActionParameters
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParameters?>();
            }

            /// <summary>An informative description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#description Ruleset#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the rule should be executed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#enabled Ruleset#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configuration for exposed credential checking.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exposed_credential_check Ruleset#exposed_credential_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exposedCredentialCheck", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesExposedCredentialCheck\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck? ExposedCredentialCheck
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck?>();
            }

            /// <summary>An object configuring the rule's logging behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#logging Ruleset#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesLogging\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesLogging? Logging
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesLogging?>();
            }

            /// <summary>An object configuring the rule's rate limit behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ratelimit Ruleset#ratelimit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ratelimit", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesRatelimit\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesRatelimit? Ratelimit
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesRatelimit?>();
            }

            /// <summary>The reference of the rule (the rule's ID by default).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#ref Ruleset#ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ref
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
