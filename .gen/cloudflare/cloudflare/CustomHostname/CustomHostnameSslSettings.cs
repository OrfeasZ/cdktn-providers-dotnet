using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    [JsiiByValue(fqn: "cloudflare.customHostname.CustomHostnameSslSettings")]
    public class CustomHostnameSslSettings : cloudflare.CustomHostname.ICustomHostnameSslSettings
    {
        /// <summary>An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#ciphers CustomHostname#ciphers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ciphers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ciphers
        {
            get;
            set;
        }

        /// <summary>Whether or not Early Hints is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#early_hints CustomHostname#early_hints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "earlyHints", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EarlyHints
        {
            get;
            set;
        }

        /// <summary>Whether or not HTTP2 is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#http2 CustomHostname#http2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Http2
        {
            get;
            set;
        }

        /// <summary>The minimum TLS version supported. Available values: "1.0", "1.1", "1.2", "1.3".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#min_tls_version CustomHostname#min_tls_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinTlsVersion
        {
            get;
            set;
        }

        /// <summary>Whether or not TLS 1.3 is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#tls_1_3 CustomHostname#tls_1_3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls13", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tls13
        {
            get;
            set;
        }
    }
}
