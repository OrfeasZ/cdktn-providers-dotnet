using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiInterface(nativeType: typeof(IActionGatewayEndpointVersionPolicyRules), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules")]
    public interface IActionGatewayEndpointVersionPolicyRules
    {
        /// <summary>allow, ask, or deny.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#action ActionGatewayEndpoint#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Tool slug, optionally pinned as &lt;tool_slug&gt;@&lt;version&gt;, or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#tool ActionGatewayEndpoint#tool}
        /// </remarks>
        [JsiiProperty(name: "tool", typeJson: "{\"primitive\":\"string\"}")]
        string Tool
        {
            get;
        }

        /// <summary>Argument values a call must match for the rule to apply, keyed by argument name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#match ActionGatewayEndpoint#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Match
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayEndpointVersionPolicyRules), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow, ask, or deny.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#action ActionGatewayEndpoint#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Tool slug, optionally pinned as &lt;tool_slug&gt;@&lt;version&gt;, or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#tool ActionGatewayEndpoint#tool}
            /// </remarks>
            [JsiiProperty(name: "tool", typeJson: "{\"primitive\":\"string\"}")]
            public string Tool
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Argument values a call must match for the rule to apply, keyed by argument name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#match ActionGatewayEndpoint#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Match
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
