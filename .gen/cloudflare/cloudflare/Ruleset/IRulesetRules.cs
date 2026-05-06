using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRules), fullyQualifiedName: "cloudflare.ruleset.RulesetRules")]
    public interface IRulesetRules
    {
        /// <summary>The action to perform when the rule matches.</summary>
        /// <remarks>
        /// Available values: "block", "challenge", "compress_response", "execute", "js_challenge", "log", "managed_challenge", "redirect", "rewrite", "route", "score", "serve_error", "set_config", "skip", "set_cache_settings", "log_custom_field", "ddos_dynamic", "force_connection_close".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>The parameters configuring the rule's action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#action_parameters Ruleset#action_parameters}
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

        /// <summary>The categories of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#categories Ruleset#categories}
        /// </remarks>
        [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Categories
        {
            get
            {
                return null;
            }
        }

        /// <summary>An informative description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#description Ruleset#description}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#enabled Ruleset#enabled}
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

        /// <summary>Configure checks for exposed credentials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exposed_credential_check Ruleset#exposed_credential_check}
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

        /// <summary>The expression defining which traffic will match the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#expression Ruleset#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>An object configuring the rule's logging behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#logging Ruleset#logging}
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

        /// <summary>An object configuring the rule's ratelimit behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ratelimit Ruleset#ratelimit}
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

        /// <summary>The reference of the rule (the rule ID by default).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ref Ruleset#ref}
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
            /// Available values: "block", "challenge", "compress_response", "execute", "js_challenge", "log", "managed_challenge", "redirect", "rewrite", "route", "score", "serve_error", "set_config", "skip", "set_cache_settings", "log_custom_field", "ddos_dynamic", "force_connection_close".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#action Ruleset#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The parameters configuring the rule's action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#action_parameters Ruleset#action_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParameters\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParameters? ActionParameters
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParameters?>();
            }

            /// <summary>The categories of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#categories Ruleset#categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Categories
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>An informative description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#description Ruleset#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the rule should be executed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#enabled Ruleset#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure checks for exposed credentials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exposed_credential_check Ruleset#exposed_credential_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exposedCredentialCheck", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesExposedCredentialCheck\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck? ExposedCredentialCheck
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck?>();
            }

            /// <summary>The expression defining which traffic will match the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#expression Ruleset#expression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An object configuring the rule's logging behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#logging Ruleset#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesLogging\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesLogging? Logging
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesLogging?>();
            }

            /// <summary>An object configuring the rule's ratelimit behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ratelimit Ruleset#ratelimit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ratelimit", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesRatelimit\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesRatelimit? Ratelimit
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesRatelimit?>();
            }

            /// <summary>The reference of the rule (the rule ID by default).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#ref Ruleset#ref}
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
