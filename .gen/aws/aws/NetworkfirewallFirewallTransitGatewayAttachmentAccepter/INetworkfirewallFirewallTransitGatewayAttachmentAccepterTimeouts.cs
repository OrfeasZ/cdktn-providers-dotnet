using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallTransitGatewayAttachmentAccepter
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts), fullyQualifiedName: "aws.networkfirewallFirewallTransitGatewayAttachmentAccepter.NetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts")]
    public interface INetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_transit_gateway_attachment_accepter#create NetworkfirewallFirewallTransitGatewayAttachmentAccepter#create}
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_transit_gateway_attachment_accepter#delete NetworkfirewallFirewallTransitGatewayAttachmentAccepter#delete}
        /// </remarks>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts), fullyQualifiedName: "aws.networkfirewallFirewallTransitGatewayAttachmentAccepter.NetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallFirewallTransitGatewayAttachmentAccepter.INetworkfirewallFirewallTransitGatewayAttachmentAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_transit_gateway_attachment_accepter#create NetworkfirewallFirewallTransitGatewayAttachmentAccepter#create}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_transit_gateway_attachment_accepter#delete NetworkfirewallFirewallTransitGatewayAttachmentAccepter#delete}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
