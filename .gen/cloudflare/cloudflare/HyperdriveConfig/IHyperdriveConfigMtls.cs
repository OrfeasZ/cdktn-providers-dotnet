using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiInterface(nativeType: typeof(IHyperdriveConfigMtls), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigMtls")]
    public interface IHyperdriveConfigMtls
    {
        /// <summary>Define CA certificate ID obtained after uploading CA cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#ca_certificate_id HyperdriveConfig#ca_certificate_id}
        /// </remarks>
        [JsiiProperty(name: "caCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define mTLS certificate ID obtained after uploading client cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#mtls_certificate_id HyperdriveConfig#mtls_certificate_id}
        /// </remarks>
        [JsiiProperty(name: "mtlsCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MtlsCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>PostgreSQL accepts `require`, `verify-ca`, and `verify-full`.</summary>
        /// <remarks>
        /// MySQL accepts <c>REQUIRED</c>, <c>VERIFY_CA</c>, and <c>VERIFY_IDENTITY</c>. The verify modes require a CA certificate; the require modes cannot be used with a CA certificate.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#sslmode HyperdriveConfig#sslmode}
        /// </remarks>
        [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sslmode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHyperdriveConfigMtls), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigMtls")]
        internal sealed class _Proxy : DeputyBase, cloudflare.HyperdriveConfig.IHyperdriveConfigMtls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Define CA certificate ID obtained after uploading CA cert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#ca_certificate_id HyperdriveConfig#ca_certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Define mTLS certificate ID obtained after uploading client cert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#mtls_certificate_id HyperdriveConfig#mtls_certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtlsCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MtlsCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>PostgreSQL accepts `require`, `verify-ca`, and `verify-full`.</summary>
            /// <remarks>
            /// MySQL accepts <c>REQUIRED</c>, <c>VERIFY_CA</c>, and <c>VERIFY_IDENTITY</c>. The verify modes require a CA certificate; the require modes cannot be used with a CA certificate.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/hyperdrive_config#sslmode HyperdriveConfig#sslmode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sslmode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
