using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiByValue(fqn: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude")]
    public class TokenValidationRulesSelectorExclude : cloudflare.TokenValidationRules.ITokenValidationRulesSelectorExclude
    {
        /// <summary>Excluded operation IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#operation_ids TokenValidationRules#operation_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OperationIds
        {
            get;
            set;
        }
    }
}
