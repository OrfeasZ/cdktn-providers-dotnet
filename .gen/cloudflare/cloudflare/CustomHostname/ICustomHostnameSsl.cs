using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    [JsiiInterface(nativeType: typeof(ICustomHostnameSsl), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSsl")]
    public interface ICustomHostnameSsl
    {
        /// <summary>A ubiquitous bundle has the highest probability of being verified everywhere, even by clients using outdated or unusual trust stores.</summary>
        /// <remarks>
        /// An optimal bundle uses the shortest chain and newest intermediates. And the force bundle verifies the chain, but does not otherwise modify it.
        /// Available values: "ubiquitous", "optimal", "force".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#bundle_method CustomHostname#bundle_method}
        /// </remarks>
        [JsiiProperty(name: "bundleMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BundleMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Certificate Authority that will issue the certificate Available values: "digicert", "google", "lets_encrypt", "ssl_com".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#certificate_authority CustomHostname#certificate_authority}
        /// </remarks>
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not to add Cloudflare Branding for the order.</summary>
        /// <remarks>
        /// This will add a subdomain of sni.cloudflaressl.com as the Common Name if set to true
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#cloudflare_branding CustomHostname#cloudflare_branding}
        /// </remarks>
        [JsiiProperty(name: "cloudflareBranding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudflareBranding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of custom certificate and key pairs (1 or 2 pairs allowed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_cert_bundle CustomHostname#custom_cert_bundle}
        /// </remarks>
        [JsiiProperty(name: "customCertBundle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslCustomCertBundle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomCertBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>If a custom uploaded certificate is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
        /// </remarks>
        [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The key for a custom uploaded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
        /// </remarks>
        [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Domain control validation (DCV) method used for this hostname. Available values: "http", "txt", "email".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#method CustomHostname#method}
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

        /// <summary>SSL specific settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#settings CustomHostname#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.CustomHostname.ICustomHostnameSslSettings? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Level of validation to be used for this hostname. Domain validation (dv) must be used. Available values: "dv".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#type CustomHostname#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the certificate covers a wildcard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#wildcard CustomHostname#wildcard}
        /// </remarks>
        [JsiiProperty(name: "wildcard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Wildcard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomHostnameSsl), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSsl")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CustomHostname.ICustomHostnameSsl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A ubiquitous bundle has the highest probability of being verified everywhere, even by clients using outdated or unusual trust stores.</summary>
            /// <remarks>
            /// An optimal bundle uses the shortest chain and newest intermediates. And the force bundle verifies the chain, but does not otherwise modify it.
            /// Available values: "ubiquitous", "optimal", "force".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#bundle_method CustomHostname#bundle_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bundleMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BundleMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Certificate Authority that will issue the certificate Available values: "digicert", "google", "lets_encrypt", "ssl_com".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#certificate_authority CustomHostname#certificate_authority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthority
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether or not to add Cloudflare Branding for the order.</summary>
            /// <remarks>
            /// This will add a subdomain of sni.cloudflaressl.com as the Common Name if set to true
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#cloudflare_branding CustomHostname#cloudflare_branding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudflareBranding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudflareBranding
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Array of custom certificate and key pairs (1 or 2 pairs allowed).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_cert_bundle CustomHostname#custom_cert_bundle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCertBundle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslCustomCertBundle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomCertBundle
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If a custom uploaded certificate is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The key for a custom uploaded certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Domain control validation (DCV) method used for this hostname. Available values: "http", "txt", "email".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#method CustomHostname#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SSL specific settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#settings CustomHostname#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslSettings\"}", isOptional: true)]
            public cloudflare.CustomHostname.ICustomHostnameSslSettings? Settings
            {
                get => GetInstanceProperty<cloudflare.CustomHostname.ICustomHostnameSslSettings?>();
            }

            /// <summary>Level of validation to be used for this hostname. Domain validation (dv) must be used. Available values: "dv".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#type CustomHostname#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether the certificate covers a wildcard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#wildcard CustomHostname#wildcard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wildcard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Wildcard
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
