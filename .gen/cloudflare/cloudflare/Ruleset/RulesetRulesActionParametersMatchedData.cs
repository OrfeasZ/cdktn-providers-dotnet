using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersMatchedData")]
    public class RulesetRulesActionParametersMatchedData : cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData
    {
        /// <summary>The public key to encrypt matched data logs with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#public_key Ruleset#public_key}
        /// </remarks>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicKey
        {
            get;
            set;
        }
    }
}
