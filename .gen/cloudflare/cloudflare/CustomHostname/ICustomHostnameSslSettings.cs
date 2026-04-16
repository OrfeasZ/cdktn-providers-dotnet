using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    [JsiiInterface(nativeType: typeof(ICustomHostnameSslSettings), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSslSettings")]
    public interface ICustomHostnameSslSettings
    {
        /// <summary>An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#ciphers CustomHostname#ciphers}
        /// </remarks>
        [JsiiProperty(name: "ciphers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ciphers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not Early Hints is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#early_hints CustomHostname#early_hints}
        /// </remarks>
        [JsiiProperty(name: "earlyHints", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EarlyHints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not HTTP2 is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#http2 CustomHostname#http2}
        /// </remarks>
        [JsiiProperty(name: "http2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Http2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum TLS version supported. Available values: "1.0", "1.1", "1.2", "1.3".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#min_tls_version CustomHostname#min_tls_version}
        /// </remarks>
        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinTlsVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not TLS 1.3 is enabled. Available values: "on", "off".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#tls_1_3 CustomHostname#tls_1_3}
        /// </remarks>
        [JsiiProperty(name: "tls13", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tls13
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomHostnameSslSettings), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSslSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CustomHostname.ICustomHostnameSslSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#ciphers CustomHostname#ciphers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ciphers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ciphers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether or not Early Hints is enabled. Available values: "on", "off".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#early_hints CustomHostname#early_hints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "earlyHints", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EarlyHints
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether or not HTTP2 is enabled. Available values: "on", "off".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#http2 CustomHostname#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Http2
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The minimum TLS version supported. Available values: "1.0", "1.1", "1.2", "1.3".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#min_tls_version CustomHostname#min_tls_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinTlsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether or not TLS 1.3 is enabled. Available values: "on", "off".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#tls_1_3 CustomHostname#tls_1_3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls13", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tls13
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
