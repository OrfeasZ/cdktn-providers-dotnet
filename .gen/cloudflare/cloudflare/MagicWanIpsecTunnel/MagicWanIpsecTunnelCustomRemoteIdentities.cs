using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    [JsiiByValue(fqn: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentities")]
    public class MagicWanIpsecTunnelCustomRemoteIdentities : cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities
    {
        /// <summary>A custom IKE ID of type FQDN that may be used to identity the IPsec tunnel.</summary>
        /// <remarks>
        /// The
        /// generated IKE IDs can still be used even if this custom value is specified.
        ///
        /// Must be of the form <c>&lt;custom label&gt;.&lt;account ID&gt;.custom.ipsec.cloudflare.com</c>.
        ///
        /// This custom ID does not need to be unique. Two IPsec tunnels may have the same custom
        /// fqdn_id. However, if another IPsec tunnel has the same value then the two tunnels
        /// cannot have the same cloudflare_endpoint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#fqdn_id MagicWanIpsecTunnel#fqdn_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fqdnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FqdnId
        {
            get;
            set;
        }
    }
}
