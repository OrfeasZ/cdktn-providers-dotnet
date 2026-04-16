using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Healthcheck
{
    [JsiiInterface(nativeType: typeof(IHealthcheckHttpConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckHttpConfig")]
    public interface IHealthcheckHttpConfig
    {
        /// <summary>Do not validate the certificate when the health check uses HTTPS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#allow_insecure Healthcheck#allow_insecure}
        /// </remarks>
        [JsiiProperty(name: "allowInsecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowInsecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>A case-insensitive sub-string to look for in the response body.</summary>
        /// <remarks>
        /// If this string is not found, the origin will be marked as unhealthy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#expected_body Healthcheck#expected_body}
        /// </remarks>
        [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpectedBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expected HTTP response codes (e.g. "200") or code ranges (e.g. "2xx" for all codes starting with 2) of the health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#expected_codes Healthcheck#expected_codes}
        /// </remarks>
        [JsiiProperty(name: "expectedCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExpectedCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Follow redirects if the origin returns a 3xx status code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#follow_redirects Healthcheck#follow_redirects}
        /// </remarks>
        [JsiiProperty(name: "followRedirects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FollowRedirects
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP request headers to send in the health check.</summary>
        /// <remarks>
        /// It is recommended you set a Host header by default. The User-Agent header cannot be overridden.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#header Healthcheck#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP method to use for the health check. Available values: "GET", "HEAD".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#method Healthcheck#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>The endpoint path to health check against.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#path Healthcheck#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Port number to connect to for the health check.</summary>
        /// <remarks>
        /// Defaults to 80 if type is HTTP or 443 if type is HTTPS.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#port Healthcheck#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcheckHttpConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckHttpConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Healthcheck.IHealthcheckHttpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Do not validate the certificate when the health check uses HTTPS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#allow_insecure Healthcheck#allow_insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowInsecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowInsecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A case-insensitive sub-string to look for in the response body.</summary>
            /// <remarks>
            /// If this string is not found, the origin will be marked as unhealthy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#expected_body Healthcheck#expected_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpectedBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The expected HTTP response codes (e.g. "200") or code ranges (e.g. "2xx" for all codes starting with 2) of the health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#expected_codes Healthcheck#expected_codes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExpectedCodes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Follow redirects if the origin returns a 3xx status code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#follow_redirects Healthcheck#follow_redirects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "followRedirects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FollowRedirects
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The HTTP request headers to send in the health check.</summary>
            /// <remarks>
            /// It is recommended you set a Host header by default. The User-Agent header cannot be overridden.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#header Healthcheck#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The HTTP method to use for the health check. Available values: "GET", "HEAD".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#method Healthcheck#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The endpoint path to health check against.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#path Healthcheck#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Port number to connect to for the health check.</summary>
            /// <remarks>
            /// Defaults to 80 if type is HTTP or 443 if type is HTTPS.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#port Healthcheck#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
