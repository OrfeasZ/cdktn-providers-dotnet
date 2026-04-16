using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationConfig
{
    [JsiiInterface(nativeType: typeof(ITokenValidationConfigCredentialsKeys), fullyQualifiedName: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys")]
    public interface ITokenValidationConfigCredentialsKeys
    {
        /// <summary>Algorithm Available values: "RS256", "RS384", "RS512", "PS256", "PS384", "PS512", "ES256", "ES384".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#alg TokenValidationConfig#alg}
        /// </remarks>
        [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}")]
        string Alg
        {
            get;
        }

        /// <summary>Key ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kid TokenValidationConfig#kid}
        /// </remarks>
        [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}")]
        string Kid
        {
            get;
        }

        /// <summary>Key Type Available values: "RSA", "EC".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kty TokenValidationConfig#kty}
        /// </remarks>
        [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}")]
        string Kty
        {
            get;
        }

        /// <summary>Curve Available values: "P-256", "P-384".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#crv TokenValidationConfig#crv}
        /// </remarks>
        [JsiiProperty(name: "crv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Crv
        {
            get
            {
                return null;
            }
        }

        /// <summary>RSA exponent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#e TokenValidationConfig#e}
        /// </remarks>
        [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? E
        {
            get
            {
                return null;
            }
        }

        /// <summary>RSA modulus.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#n TokenValidationConfig#n}
        /// </remarks>
        [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? N
        {
            get
            {
                return null;
            }
        }

        /// <summary>X EC coordinate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#x TokenValidationConfig#x}
        /// </remarks>
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? X
        {
            get
            {
                return null;
            }
        }

        /// <summary>Y EC coordinate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#y TokenValidationConfig#y}
        /// </remarks>
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Y
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationConfigCredentialsKeys), fullyQualifiedName: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationConfig.ITokenValidationConfigCredentialsKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Algorithm Available values: "RS256", "RS384", "RS512", "PS256", "PS384", "PS512", "ES256", "ES384".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#alg TokenValidationConfig#alg}
            /// </remarks>
            [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}")]
            public string Alg
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Key ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kid TokenValidationConfig#kid}
            /// </remarks>
            [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}")]
            public string Kid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Key Type Available values: "RSA", "EC".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kty TokenValidationConfig#kty}
            /// </remarks>
            [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}")]
            public string Kty
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Curve Available values: "P-256", "P-384".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#crv TokenValidationConfig#crv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Crv
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>RSA exponent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#e TokenValidationConfig#e}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? E
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>RSA modulus.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#n TokenValidationConfig#n}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? N
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>X EC coordinate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#x TokenValidationConfig#x}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? X
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Y EC coordinate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#y TokenValidationConfig#y}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Y
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
