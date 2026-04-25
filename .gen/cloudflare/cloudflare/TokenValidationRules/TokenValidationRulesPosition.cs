using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiByValue(fqn: "cloudflare.tokenValidationRules.TokenValidationRulesPosition")]
    public class TokenValidationRulesPosition : cloudflare.TokenValidationRules.ITokenValidationRulesPosition
    {
        /// <summary>Move rule to after rule with this ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#after TokenValidationRules#after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? After
        {
            get;
            set;
        }

        /// <summary>Move rule to before rule with this ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#before TokenValidationRules#before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "before", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Before
        {
            get;
            set;
        }

        /// <summary>Move rule to this position.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#index TokenValidationRules#index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Index
        {
            get;
            set;
        }
    }
}
