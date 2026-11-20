using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules")]
    public class ActionGatewayEndpointVersionPolicyRules : digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules
    {
        /// <summary>allow, ask, or deny.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#action ActionGatewayEndpoint#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Tool slug, optionally pinned as &lt;tool_slug&gt;@&lt;version&gt;, or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#tool ActionGatewayEndpoint#tool}
        /// </remarks>
        [JsiiProperty(name: "tool", typeJson: "{\"primitive\":\"string\"}")]
        public string Tool
        {
            get;
            set;
        }

        /// <summary>Argument values a call must match for the rule to apply, keyed by argument name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#match ActionGatewayEndpoint#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Match
        {
            get;
            set;
        }
    }
}
