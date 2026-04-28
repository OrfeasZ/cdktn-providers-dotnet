using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceCors), fullyQualifiedName: "digitalocean.app.AppSpecServiceCors")]
    public interface IAppSpecServiceCors
    {
        /// <summary>Whether browsers should expose the response to the client-side JavaScript code when the request’s credentials mode is `include`.</summary>
        /// <remarks>
        /// This configures the Access-Control-Allow-Credentials header.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_credentials App#allow_credentials}
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

        /// <summary>The set of allowed HTTP request headers. This configures the Access-Control-Allow-Headers header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_headers App#allow_headers}
        /// </remarks>
        [JsiiProperty(name: "allowHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>The set of allowed HTTP methods. This configures the Access-Control-Allow-Methods header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_methods App#allow_methods}
        /// </remarks>
        [JsiiProperty(name: "allowMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>allow_origins block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_origins App#allow_origins}
        /// </remarks>
        [JsiiProperty(name: "allowOrigins", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCorsAllowOrigins\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceCorsAllowOrigins? AllowOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>The set of HTTP response headers that browsers are allowed to access. This configures the Access-Control-Expose-Headers header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#expose_headers App#expose_headers}
        /// </remarks>
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExposeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional duration specifying how long browsers can cache the results of a preflight request.</summary>
        /// <remarks>
        /// This configures the Access-Control-Max-Age header. Example: <c>5h30m</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#max_age App#max_age}
        /// </remarks>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxAge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceCors), fullyQualifiedName: "digitalocean.app.AppSpecServiceCors")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceCors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether browsers should expose the response to the client-side JavaScript code when the request’s credentials mode is `include`.</summary>
            /// <remarks>
            /// This configures the Access-Control-Allow-Credentials header.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_credentials App#allow_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The set of allowed HTTP request headers. This configures the Access-Control-Allow-Headers header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_headers App#allow_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The set of allowed HTTP methods. This configures the Access-Control-Allow-Methods header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_methods App#allow_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowMethods
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>allow_origins block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#allow_origins App#allow_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowOrigins", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCorsAllowOrigins\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceCorsAllowOrigins? AllowOrigins
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceCorsAllowOrigins?>();
            }

            /// <summary>The set of HTTP response headers that browsers are allowed to access. This configures the Access-Control-Expose-Headers header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#expose_headers App#expose_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExposeHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>An optional duration specifying how long browsers can cache the results of a preflight request.</summary>
            /// <remarks>
            /// This configures the Access-Control-Max-Age header. Example: <c>5h30m</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#max_age App#max_age}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxAge
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
