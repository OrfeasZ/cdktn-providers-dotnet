using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IActionGatewayConnectionVpc), fullyQualifiedName: "digitalocean.actionGatewayConnection.ActionGatewayConnectionVpc")]
    public interface IActionGatewayConnectionVpc
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#destination ActionGatewayConnection#destination}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpcDestination\"},\"kind\":\"array\"}}]}}")]
        object Destination
        {
            get;
        }

        /// <summary>UUID of a VPC owned by your team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#vpc_uuid ActionGatewayConnection#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        string VpcUuid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayConnectionVpc), fullyQualifiedName: "digitalocean.actionGatewayConnection.ActionGatewayConnectionVpc")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#destination ActionGatewayConnection#destination}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpcDestination\"},\"kind\":\"array\"}}]}}")]
            public object Destination
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>UUID of a VPC owned by your team.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#vpc_uuid ActionGatewayConnection#vpc_uuid}
            /// </remarks>
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcUuid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
