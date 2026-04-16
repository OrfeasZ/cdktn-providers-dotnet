using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Healthcheck
{
    [JsiiByValue(fqn: "cloudflare.healthcheck.HealthcheckHttpConfig")]
    public class HealthcheckHttpConfig : cloudflare.Healthcheck.IHealthcheckHttpConfig
    {
        private object? _allowInsecure;

        /// <summary>Do not validate the certificate when the health check uses HTTPS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#allow_insecure Healthcheck#allow_insecure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowInsecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowInsecure
        {
            get => _allowInsecure;
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
                _allowInsecure = value;
            }
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
            get;
            set;
        }

        /// <summary>The expected HTTP response codes (e.g. "200") or code ranges (e.g. "2xx" for all codes starting with 2) of the health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#expected_codes Healthcheck#expected_codes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expectedCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExpectedCodes
        {
            get;
            set;
        }

        private object? _followRedirects;

        /// <summary>Follow redirects if the origin returns a 3xx status code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#follow_redirects Healthcheck#follow_redirects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "followRedirects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FollowRedirects
        {
            get => _followRedirects;
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
                _followRedirects = value;
            }
        }

        private object? _header;

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
            get => _header;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _header = value;
            }
        }

        /// <summary>The HTTP method to use for the health check. Available values: "GET", "HEAD".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#method Healthcheck#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Method
        {
            get;
            set;
        }

        /// <summary>The endpoint path to health check against.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/healthcheck#path Healthcheck#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
