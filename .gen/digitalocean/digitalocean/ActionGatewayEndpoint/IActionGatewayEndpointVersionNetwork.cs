using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiInterface(nativeType: typeof(IActionGatewayEndpointVersionNetwork), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork")]
    public interface IActionGatewayEndpointVersionNetwork
    {
        /// <summary>UUID of a VPC owned by your team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#vpc_uuid ActionGatewayEndpoint#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        string VpcUuid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayEndpointVersionNetwork), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of a VPC owned by your team.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#vpc_uuid ActionGatewayEndpoint#vpc_uuid}
            /// </remarks>
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcUuid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
