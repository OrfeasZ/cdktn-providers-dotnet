using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiByValue(fqn: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersion")]
    public class ActionGatewayEndpointVersion : digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersion
    {
        /// <summary>Actor the version's tool calls act as. No operation changes an endpoint's actor, so changing this replaces the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#actor_id ActionGatewayEndpoint#actor_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActorId
        {
            get;
            set;
        }

        /// <summary>JSON object of options Gateway applies to the version, such as preloadTools or customInstructions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#config ActionGatewayEndpoint#config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Config
        {
            get;
            set;
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#network ActionGatewayEndpoint#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork\"}", isOptional: true)]
        public digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork? Network
        {
            get;
            set;
        }

        /// <summary>policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#policy ActionGatewayEndpoint#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy\"}", isOptional: true)]
        public digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy? Policy
        {
            get;
            set;
        }

        /// <summary>Tools and toolbelts the version enables, each optionally pinned as &lt;tool_slug&gt;@&lt;version&gt; or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
        /// <remarks>
        /// Omit to enable every tool; set an empty list to enable none.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#tools ActionGatewayEndpoint#tools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Tools
        {
            get;
            set;
        }
    }
}
