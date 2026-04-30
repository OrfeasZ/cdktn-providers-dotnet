using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleActionJwtValidation")]
    public class AlbListenerRuleActionJwtValidation : aws.AlbListenerRule.IAlbListenerRuleActionJwtValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#issuer AlbListenerRule#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#jwks_endpoint AlbListenerRule#jwks_endpoint}.</summary>
        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string JwksEndpoint
        {
            get;
            set;
        }

        private object? _additionalClaim;

        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#additional_claim AlbListenerRule#additional_claim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalClaim
        {
            get => _additionalClaim;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AlbListenerRule.IAlbListenerRuleActionJwtValidationAdditionalClaim[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleActionJwtValidationAdditionalClaim).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalClaim = value;
            }
        }
    }
}
