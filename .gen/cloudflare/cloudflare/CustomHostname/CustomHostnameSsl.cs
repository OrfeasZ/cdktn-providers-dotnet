using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    [JsiiByValue(fqn: "cloudflare.customHostname.CustomHostnameSsl")]
    public class CustomHostnameSsl : cloudflare.CustomHostname.ICustomHostnameSsl
    {
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
            get;
            set;
        }

        /// <summary>The Certificate Authority that will issue the certificate Available values: "digicert", "google", "lets_encrypt", "ssl_com".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#certificate_authority CustomHostname#certificate_authority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthority
        {
            get;
            set;
        }

        private object? _cloudflareBranding;

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
            get => _cloudflareBranding;
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
                _cloudflareBranding = value;
            }
        }

        private object? _customCertBundle;

        /// <summary>Array of custom certificate and key pairs (1 or 2 pairs allowed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_cert_bundle CustomHostname#custom_cert_bundle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customCertBundle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslCustomCertBundle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomCertBundle
        {
            get => _customCertBundle;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.CustomHostname.ICustomHostnameSslCustomCertBundle[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.CustomHostname.ICustomHostnameSslCustomCertBundle).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customCertBundle = value;
            }
        }

        /// <summary>If a custom uploaded certificate is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomCertificate
        {
            get;
            set;
        }

        /// <summary>The key for a custom uploaded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomKey
        {
            get;
            set;
        }

        /// <summary>Domain control validation (DCV) method used for this hostname. Available values: "http", "txt", "email".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#method CustomHostname#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Method
        {
            get;
            set;
        }

        /// <summary>SSL specific settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#settings CustomHostname#settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.customHostname.CustomHostnameSslSettings\"}", isOptional: true)]
        public cloudflare.CustomHostname.ICustomHostnameSslSettings? Settings
        {
            get;
            set;
        }

        /// <summary>Level of validation to be used for this hostname. Domain validation (dv) must be used. Available values: "dv".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#type CustomHostname#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        private object? _wildcard;

        /// <summary>Indicates whether the certificate covers a wildcard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#wildcard CustomHostname#wildcard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wildcard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Wildcard
        {
            get => _wildcard;
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
                _wildcard = value;
            }
        }
    }
}
