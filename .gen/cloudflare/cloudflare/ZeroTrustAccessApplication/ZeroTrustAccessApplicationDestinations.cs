using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationDestinations")]
    public class ZeroTrustAccessApplicationDestinations : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationDestinations
    {
        /// <summary>The CIDR range of the destination. Single IPs will be computed as /32.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#cidr ZeroTrustAccessApplication#cidr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cidr
        {
            get;
            set;
        }

        /// <summary>The hostname of the destination. Matches a valid SNI served by an HTTPS origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#hostname ZeroTrustAccessApplication#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>The L4 protocol of the destination. When omitted, both UDP and TCP traffic will match. Available values: "tcp", "udp".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#l4_protocol ZeroTrustAccessApplication#l4_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "l4Protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? L4Protocol
        {
            get;
            set;
        }

        /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#mcp_server_id ZeroTrustAccessApplication#mcp_server_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcpServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? McpServerId
        {
            get;
            set;
        }

        /// <summary>The port range of the destination.</summary>
        /// <remarks>
        /// Can be a single port or a range of ports. When omitted, all ports will match.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#port_range ZeroTrustAccessApplication#port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }

        /// <summary>Available values: "public", "private".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#type ZeroTrustAccessApplication#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>The URI of the destination. Public destinations' URIs can include a domain and path with [wildcards](https://developers.cloudflare.com/cloudflare-one/policies/access/app-paths/).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#uri ZeroTrustAccessApplication#uri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }

        /// <summary>The VNET ID to match the destination. When omitted, all VNETs will match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#vnet_id ZeroTrustAccessApplication#vnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VnetId
        {
            get;
            set;
        }
    }
}
