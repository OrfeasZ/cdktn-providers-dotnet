using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecFunctionCors")]
    public class AppSpecFunctionCors : digitalocean.App.IAppSpecFunctionCors
    {
        private object? _allowCredentials;

        /// <summary>Whether browsers should expose the response to the client-side JavaScript code when the request’s credentials mode is `include`.</summary>
        /// <remarks>
        /// This configures the Access-Control-Allow-Credentials header.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#allow_credentials App#allow_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowCredentials
        {
            get => _allowCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowCredentials = value;
            }
        }

        /// <summary>The set of allowed HTTP request headers. This configures the Access-Control-Allow-Headers header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#allow_headers App#allow_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowHeaders
        {
            get;
            set;
        }

        /// <summary>The set of allowed HTTP methods. This configures the Access-Control-Allow-Methods header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#allow_methods App#allow_methods}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowMethods
        {
            get;
            set;
        }

        /// <summary>allow_origins block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#allow_origins App#allow_origins}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowOrigins", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCorsAllowOrigins\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionCorsAllowOrigins? AllowOrigins
        {
            get;
            set;
        }

        /// <summary>The set of HTTP response headers that browsers are allowed to access. This configures the Access-Control-Expose-Headers header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#expose_headers App#expose_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExposeHeaders
        {
            get;
            set;
        }

        /// <summary>An optional duration specifying how long browsers can cache the results of a preflight request.</summary>
        /// <remarks>
        /// This configures the Access-Control-Max-Age header. Example: <c>5h30m</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#max_age App#max_age}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxAge
        {
            get;
            set;
        }
    }
}
