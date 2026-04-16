using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationCorsHeaders), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationCorsHeaders")]
    public interface IZeroTrustAccessApplicationCorsHeaders
    {
        /// <summary>Allows all HTTP request headers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_headers ZeroTrustAccessApplication#allow_all_headers}
        /// </remarks>
        [JsiiProperty(name: "allowAllHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAllHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows all HTTP request methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_methods ZeroTrustAccessApplication#allow_all_methods}
        /// </remarks>
        [JsiiProperty(name: "allowAllMethods", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAllMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows all origins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_origins ZeroTrustAccessApplication#allow_all_origins}
        /// </remarks>
        [JsiiProperty(name: "allowAllOrigins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAllOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to `true`, includes credentials (cookies, authorization headers, or TLS client certificates) with requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_credentials ZeroTrustAccessApplication#allow_credentials}
        /// </remarks>
        [JsiiProperty(name: "allowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allowed HTTP request headers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_headers ZeroTrustAccessApplication#allowed_headers}
        /// </remarks>
        [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allowed HTTP request methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_methods ZeroTrustAccessApplication#allowed_methods}
        /// </remarks>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allowed origins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_origins ZeroTrustAccessApplication#allowed_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of seconds the results of a preflight request can be cached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#max_age ZeroTrustAccessApplication#max_age}
        /// </remarks>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationCorsHeaders), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationCorsHeaders")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationCorsHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allows all HTTP request headers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_headers ZeroTrustAccessApplication#allow_all_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAllHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAllHeaders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allows all HTTP request methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_methods ZeroTrustAccessApplication#allow_all_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAllMethods", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAllMethods
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allows all origins.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_all_origins ZeroTrustAccessApplication#allow_all_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAllOrigins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAllOrigins
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When set to `true`, includes credentials (cookies, authorization headers, or TLS client certificates) with requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_credentials ZeroTrustAccessApplication#allow_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allowed HTTP request headers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_headers ZeroTrustAccessApplication#allowed_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Allowed HTTP request methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_methods ZeroTrustAccessApplication#allowed_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedMethods
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Allowed origins.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allowed_origins ZeroTrustAccessApplication#allowed_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The maximum number of seconds the results of a preflight request can be cached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#max_age ZeroTrustAccessApplication#max_age}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAge
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
