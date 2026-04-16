using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceManagedNetworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceManagedNetworks.ZeroTrustDeviceManagedNetworksConfigA")]
    public class ZeroTrustDeviceManagedNetworksConfigA : cloudflare.ZeroTrustDeviceManagedNetworks.IZeroTrustDeviceManagedNetworksConfigA
    {
        /// <summary>A network address of the form "host:port" that the WARP client will use to detect the presence of a TLS host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_managed_networks#tls_sockaddr ZeroTrustDeviceManagedNetworks#tls_sockaddr}
        /// </remarks>
        [JsiiProperty(name: "tlsSockaddr", typeJson: "{\"primitive\":\"string\"}")]
        public string TlsSockaddr
        {
            get;
            set;
        }

        /// <summary>The SHA-256 hash of the TLS certificate presented by the host found at tls_sockaddr.</summary>
        /// <remarks>
        /// If absent, regular certificate verification (trusted roots, valid timestamp, etc) will be used to validate the certificate.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_managed_networks#sha256 ZeroTrustDeviceManagedNetworks#sha256}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sha256
        {
            get;
            set;
        }
    }
}
