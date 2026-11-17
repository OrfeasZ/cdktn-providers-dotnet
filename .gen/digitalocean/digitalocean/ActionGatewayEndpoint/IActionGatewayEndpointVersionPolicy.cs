using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiInterface(nativeType: typeof(IActionGatewayEndpointVersionPolicy), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy")]
    public interface IActionGatewayEndpointVersionPolicy
    {
        /// <summary>Action for calls no rule matches: allow, ask, or deny. Empty means ask.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#default_action ActionGatewayEndpoint#default_action}
        /// </remarks>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#rules ActionGatewayEndpoint#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayEndpointVersionPolicy), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Action for calls no rule matches: allow, ask, or deny. Empty means ask.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#default_action ActionGatewayEndpoint#default_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#rules ActionGatewayEndpoint#rules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
