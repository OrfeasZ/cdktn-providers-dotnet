using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleActionJwtValidation")]
    public interface IAlbListenerRuleActionJwtValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#issuer AlbListenerRule#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#jwks_endpoint AlbListenerRule#jwks_endpoint}.</summary>
        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string JwksEndpoint
        {
            get;
        }

        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#additional_claim AlbListenerRule#additional_claim}
        /// </remarks>
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalClaim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleActionJwtValidation")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleActionJwtValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#issuer AlbListenerRule#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#jwks_endpoint AlbListenerRule#jwks_endpoint}.</summary>
            [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string JwksEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#additional_claim AlbListenerRule#additional_claim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalClaim
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
