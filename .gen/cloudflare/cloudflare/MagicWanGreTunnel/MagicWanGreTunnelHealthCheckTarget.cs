using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanGreTunnel
{
    [JsiiByValue(fqn: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheckTarget")]
    public class MagicWanGreTunnelHealthCheckTarget : cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheckTarget
    {
        /// <summary>The saved health check target.</summary>
        /// <remarks>
        /// Setting the value to the empty string indicates that the calculated default value will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#saved MagicWanGreTunnel#saved}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Saved
        {
            get;
            set;
        }
    }
}
