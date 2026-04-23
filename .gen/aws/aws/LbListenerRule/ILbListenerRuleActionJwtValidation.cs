using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleActionJwtValidation")]
    public interface ILbListenerRuleActionJwtValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#issuer LbListenerRule#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#jwks_endpoint LbListenerRule#jwks_endpoint}.</summary>
        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string JwksEndpoint
        {
            get;
        }

        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#additional_claim LbListenerRule#additional_claim}
        /// </remarks>
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalClaim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleActionJwtValidation")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleActionJwtValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#issuer LbListenerRule#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#jwks_endpoint LbListenerRule#jwks_endpoint}.</summary>
            [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string JwksEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#additional_claim LbListenerRule#additional_claim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalClaim
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
