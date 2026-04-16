using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiByValue(fqn: "cloudflare.hyperdriveConfig.HyperdriveConfigMtls")]
    public class HyperdriveConfigMtls : cloudflare.HyperdriveConfig.IHyperdriveConfigMtls
    {
        /// <summary>Define CA certificate ID obtained after uploading CA cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#ca_certificate_id HyperdriveConfig#ca_certificate_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "caCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaCertificateId
        {
            get;
            set;
        }

        /// <summary>Define mTLS certificate ID obtained after uploading client cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#mtls_certificate_id HyperdriveConfig#mtls_certificate_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtlsCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MtlsCertificateId
        {
            get;
            set;
        }

        /// <summary>Set SSL mode to 'require', 'verify-ca', or 'verify-full' to verify the CA.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#sslmode HyperdriveConfig#sslmode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sslmode
        {
            get;
            set;
        }
    }
}
