using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersOverrides), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersOverrides")]
    public interface IRulesetRulesActionParametersOverrides
    {
        /// <summary>An action to override all rules with. This option has lower precedence than rule and category overrides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action Ruleset#action}
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

        /// <summary>A list of category-level overrides. This option has the second-highest precedence after rule-level overrides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#categories Ruleset#categories}
        /// </remarks>
        [JsiiProperty(name: "categories", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverridesCategories\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Categories
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable execution of all rules. This option has lower precedence than rule and category overrides.</summary>
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

        /// <summary>A list of rule-level overrides. This option has the highest precedence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#rules Ruleset#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverridesRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>A sensitivity level to set for all rules.</summary>
        /// <remarks>
        /// This option has lower precedence than rule and category overrides and is only applicable for DDoS phases.
        /// Available values: "default", "medium", "low", "eoff".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#sensitivity_level Ruleset#sensitivity_level}
        /// </remarks>
        [JsiiProperty(name: "sensitivityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensitivityLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersOverrides), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersOverrides")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An action to override all rules with. This option has lower precedence than rule and category overrides.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#action Ruleset#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of category-level overrides. This option has the second-highest precedence after rule-level overrides.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#categories Ruleset#categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "categories", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverridesCategories\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Categories
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to enable execution of all rules. This option has lower precedence than rule and category overrides.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#enabled Ruleset#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of rule-level overrides. This option has the highest precedence.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#rules Ruleset#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersOverridesRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A sensitivity level to set for all rules.</summary>
            /// <remarks>
            /// This option has lower precedence than rule and category overrides and is only applicable for DDoS phases.
            /// Available values: "default", "medium", "low", "eoff".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#sensitivity_level Ruleset#sensitivity_level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensitivityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensitivityLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
