using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CertificatePack
{
    [JsiiInterface(nativeType: typeof(ICertificatePackConfig), fullyQualifiedName: "cloudflare.certificatePack.CertificatePackConfig")]
    public interface ICertificatePackConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Certificate Authority selected for the order.</summary>
        /// <remarks>
        /// For information on any certificate authority specific details or restrictions <a href="https://developers.cloudflare.com/ssl/reference/certificate-authorities">see this page for more details.</a>
        /// Available values: "google", "lets_encrypt", "ssl_com".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#certificate_authority CertificatePack#certificate_authority}
        /// </remarks>
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateAuthority
        {
            get;
        }

        /// <summary>Type of certificate pack. Available values: "advanced".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#type CertificatePack#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Validation Method selected for the order. Available values: "txt", "http", "email".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#validation_method CertificatePack#validation_method}
        /// </remarks>
        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationMethod
        {
            get;
        }

        /// <summary>Validity Days selected for the order. Available values: 14, 30, 90, 365.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#validity_days CertificatePack#validity_days}
        /// </remarks>
        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}")]
        double ValidityDays
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#zone_id CertificatePack#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Whether or not to add Cloudflare Branding for the order.</summary>
        /// <remarks>
        /// This will add a subdomain of sni.cloudflaressl.com as the Common Name if set to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#cloudflare_branding CertificatePack#cloudflare_branding}
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

        /// <summary>Comma separated list of valid host names for the certificate packs.</summary>
        /// <remarks>
        /// Must contain the zone apex, may not contain more than 50 hosts, and may not be empty.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#hosts CertificatePack#hosts}
        /// </remarks>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Hosts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatePackConfig), fullyQualifiedName: "cloudflare.certificatePack.CertificatePackConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CertificatePack.ICertificatePackConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Certificate Authority selected for the order.</summary>
            /// <remarks>
            /// For information on any certificate authority specific details or restrictions <a href="https://developers.cloudflare.com/ssl/reference/certificate-authorities">see this page for more details.</a>
            /// Available values: "google", "lets_encrypt", "ssl_com".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#certificate_authority CertificatePack#certificate_authority}
            /// </remarks>
            [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateAuthority
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of certificate pack. Available values: "advanced".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#type CertificatePack#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Validation Method selected for the order. Available values: "txt", "http", "email".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#validation_method CertificatePack#validation_method}
            /// </remarks>
            [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Validity Days selected for the order. Available values: 14, 30, 90, 365.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#validity_days CertificatePack#validity_days}
            /// </remarks>
            [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}")]
            public double ValidityDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#zone_id CertificatePack#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not to add Cloudflare Branding for the order.</summary>
            /// <remarks>
            /// This will add a subdomain of sni.cloudflaressl.com as the Common Name if set to true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#cloudflare_branding CertificatePack#cloudflare_branding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudflareBranding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudflareBranding
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Comma separated list of valid host names for the certificate packs.</summary>
            /// <remarks>
            /// Must contain the zone apex, may not contain more than 50 hosts, and may not be empty.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/certificate_pack#hosts CertificatePack#hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Hosts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
