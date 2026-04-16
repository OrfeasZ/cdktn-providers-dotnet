using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys")]
    public class TokenValidationConfigCredentialsKeys : cloudflare.TokenValidationConfig.ITokenValidationConfigCredentialsKeys
    {
        /// <summary>Algorithm Available values: "RS256", "RS384", "RS512", "PS256", "PS384", "PS512", "ES256", "ES384".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#alg TokenValidationConfig#alg}
        /// </remarks>
        [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}")]
        public string Alg
        {
            get;
            set;
        }

        /// <summary>Key ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kid TokenValidationConfig#kid}
        /// </remarks>
        [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}")]
        public string Kid
        {
            get;
            set;
        }

        /// <summary>Key Type Available values: "RSA", "EC".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#kty TokenValidationConfig#kty}
        /// </remarks>
        [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}")]
        public string Kty
        {
            get;
            set;
        }

        /// <summary>Curve Available values: "P-256", "P-384".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#crv TokenValidationConfig#crv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Crv
        {
            get;
            set;
        }

        /// <summary>RSA exponent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#e TokenValidationConfig#e}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? E
        {
            get;
            set;
        }

        /// <summary>RSA modulus.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#n TokenValidationConfig#n}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? N
        {
            get;
            set;
        }

        /// <summary>X EC coordinate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#x TokenValidationConfig#x}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? X
        {
            get;
            set;
        }

        /// <summary>Y EC coordinate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#y TokenValidationConfig#y}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Y
        {
            get;
            set;
        }
    }
}
