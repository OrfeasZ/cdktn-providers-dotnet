using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork")]
    public class ActionGatewayEndpointVersionNetwork : digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork
    {
        /// <summary>UUID of a VPC owned by your team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#vpc_uuid ActionGatewayEndpoint#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcUuid
        {
            get;
            set;
        }
    }
}
