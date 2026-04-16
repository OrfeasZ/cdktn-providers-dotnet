using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IpamIp
{
    [JsiiInterface(nativeType: typeof(IIpamIpSource), fullyQualifiedName: "scaleway.ipamIp.IpamIpSource")]
    public interface IIpamIpSource
    {
        /// <summary>Private Network the IP lives in if the IP is a private IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#private_network_id IpamIp#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Private Network subnet the IP lives in if the IP is a private IP in a Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#subnet_id IpamIp#subnet_id}
        /// </remarks>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Zone the IP lives in if the IP is a public zoned one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#zonal IpamIp#zonal}
        /// </remarks>
        [JsiiProperty(name: "zonal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zonal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIpamIpSource), fullyQualifiedName: "scaleway.ipamIp.IpamIpSource")]
        internal sealed class _Proxy : DeputyBase, scaleway.IpamIp.IIpamIpSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Private Network the IP lives in if the IP is a private IP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#private_network_id IpamIp#private_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Private Network subnet the IP lives in if the IP is a private IP in a Private Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#subnet_id IpamIp#subnet_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Zone the IP lives in if the IP is a public zoned one.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#zonal IpamIp#zonal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zonal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zonal
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
