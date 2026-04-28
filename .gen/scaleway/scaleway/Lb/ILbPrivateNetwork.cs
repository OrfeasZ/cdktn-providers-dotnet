using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Lb
{
    [JsiiInterface(nativeType: typeof(ILbPrivateNetwork), fullyQualifiedName: "scaleway.lb.LbPrivateNetwork")]
    public interface ILbPrivateNetwork
    {
        /// <summary>The Private Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb#private_network_id Lb#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateNetworkId
        {
            get;
        }

        /// <summary>IPAM ID of a pre-reserved IP address to assign to the Load Balancer on this Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb#ipam_ids Lb#ipam_ids}
        /// </remarks>
        [JsiiProperty(name: "ipamIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpamIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbPrivateNetwork), fullyQualifiedName: "scaleway.lb.LbPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.Lb.ILbPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Private Network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb#private_network_id Lb#private_network_id}
            /// </remarks>
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IPAM ID of a pre-reserved IP address to assign to the Load Balancer on this Private Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb#ipam_ids Lb#ipam_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipamIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpamIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
