using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesExposedCredentialCheck), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesExposedCredentialCheck")]
    public interface IRulesetRulesExposedCredentialCheck
    {
        /// <summary>An expression that selects the password used in the credentials check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#password_expression Ruleset#password_expression}
        /// </remarks>
        [JsiiProperty(name: "passwordExpression", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordExpression
        {
            get;
        }

        /// <summary>An expression that selects the user ID used in the credentials check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#username_expression Ruleset#username_expression}
        /// </remarks>
        [JsiiProperty(name: "usernameExpression", typeJson: "{\"primitive\":\"string\"}")]
        string UsernameExpression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesExposedCredentialCheck), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesExposedCredentialCheck")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An expression that selects the password used in the credentials check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#password_expression Ruleset#password_expression}
            /// </remarks>
            [JsiiProperty(name: "passwordExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An expression that selects the user ID used in the credentials check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#username_expression Ruleset#username_expression}
            /// </remarks>
            [JsiiProperty(name: "usernameExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string UsernameExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
