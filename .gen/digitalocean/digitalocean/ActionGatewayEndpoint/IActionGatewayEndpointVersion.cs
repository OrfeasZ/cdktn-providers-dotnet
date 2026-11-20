using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiInterface(nativeType: typeof(IActionGatewayEndpointVersion), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersion")]
    public interface IActionGatewayEndpointVersion
    {
        /// <summary>Actor the version's tool calls act as. No operation changes an endpoint's actor, so changing this replaces the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#actor_id ActionGatewayEndpoint#actor_id}
        /// </remarks>
        [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>JSON object of options Gateway applies to the version, such as preloadTools or customInstructions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#config ActionGatewayEndpoint#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#network ActionGatewayEndpoint#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#policy ActionGatewayEndpoint#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Tools and toolbelts the version enables, each optionally pinned as &lt;tool_slug&gt;@&lt;version&gt; or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
        /// <remarks>
        /// Omit to enable every tool; set an empty list to enable none.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#tools ActionGatewayEndpoint#tools}
        /// </remarks>
        [JsiiProperty(name: "tools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tools
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayEndpointVersion), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersion")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Actor the version's tool calls act as. No operation changes an endpoint's actor, so changing this replaces the endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#actor_id ActionGatewayEndpoint#actor_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>JSON object of options Gateway applies to the version, such as preloadTools or customInstructions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#config ActionGatewayEndpoint#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Config
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#network ActionGatewayEndpoint#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork\"}", isOptional: true)]
            public digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork? Network
            {
                get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork?>();
            }

            /// <summary>policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#policy ActionGatewayEndpoint#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy\"}", isOptional: true)]
            public digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy? Policy
            {
                get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy?>();
            }

            /// <summary>Tools and toolbelts the version enables, each optionally pinned as &lt;tool_slug&gt;@&lt;version&gt; or toolbelt:&lt;name&gt;@&lt;version&gt;.</summary>
            /// <remarks>
            /// Omit to enable every tool; set an empty list to enable none.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_endpoint#tools ActionGatewayEndpoint#tools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tools
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
