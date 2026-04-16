using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiByValue(fqn: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude")]
    public class TokenValidationRulesSelectorInclude : cloudflare.TokenValidationRules.ITokenValidationRulesSelectorInclude
    {
        /// <summary>Included hostnames.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#host TokenValidationRules#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Host
        {
            get;
            set;
        }
    }
}
