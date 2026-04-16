using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListener
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbListener.LbListenerDefaultActionJwtValidation")]
    public class LbListenerDefaultActionJwtValidation : aws.LbListener.ILbListenerDefaultActionJwtValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener#issuer LbListener#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener#jwks_endpoint LbListener#jwks_endpoint}.</summary>
        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string JwksEndpoint
        {
            get;
            set;
        }

        private object? _additionalClaim;

        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener#additional_claim LbListener#additional_claim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.LbListener.ILbListenerDefaultActionJwtValidationAdditionalClaim[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultActionJwtValidationAdditionalClaim).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalClaim = value;
            }
        }
    }
}
