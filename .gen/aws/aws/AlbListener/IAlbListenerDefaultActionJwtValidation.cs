using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListener
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultActionJwtValidation), fullyQualifiedName: "aws.albListener.AlbListenerDefaultActionJwtValidation")]
    public interface IAlbListenerDefaultActionJwtValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#issuer AlbListener#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#jwks_endpoint AlbListener#jwks_endpoint}.</summary>
        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string JwksEndpoint
        {
            get;
        }

        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#additional_claim AlbListener#additional_claim}
        /// </remarks>
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalClaim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultActionJwtValidation), fullyQualifiedName: "aws.albListener.AlbListenerDefaultActionJwtValidation")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListener.IAlbListenerDefaultActionJwtValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#issuer AlbListener#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#jwks_endpoint AlbListener#jwks_endpoint}.</summary>
            [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string JwksEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener#additional_claim AlbListener#additional_claim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalClaim
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
