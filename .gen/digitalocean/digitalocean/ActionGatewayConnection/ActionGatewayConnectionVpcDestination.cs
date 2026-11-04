using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.actionGatewayConnection.ActionGatewayConnectionVpcDestination")]
    public class ActionGatewayConnectionVpcDestination : digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination
    {
        /// <summary>Host name or IP address that resolves only to private addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#host ActionGatewayConnection#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public string Host
        {
            get;
            set;
        }

        /// <summary>Destination port.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#port ActionGatewayConnection#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>CIDR ranges that every address the host resolves to must fall within.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#allowed_ip_cidrs ActionGatewayConnection#allowed_ip_cidrs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedIpCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedIpCidrs
        {
            get;
            set;
        }
    }
}
