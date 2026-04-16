using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesExposedCredentialCheck")]
    public class RulesetRulesExposedCredentialCheck : cloudflare.Ruleset.IRulesetRulesExposedCredentialCheck
    {
        /// <summary>An expression that selects the password used in the credentials check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#password_expression Ruleset#password_expression}
        /// </remarks>
        [JsiiProperty(name: "passwordExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordExpression
        {
            get;
            set;
        }

        /// <summary>An expression that selects the user ID used in the credentials check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#username_expression Ruleset#username_expression}
        /// </remarks>
        [JsiiProperty(name: "usernameExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string UsernameExpression
        {
            get;
            set;
        }
    }
}
