using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IpamIp
{
    [JsiiInterface(nativeType: typeof(IIpamIpCustomResource), fullyQualifiedName: "scaleway.ipamIp.IpamIpCustomResource")]
    public interface IIpamIpCustomResource
    {
        /// <summary>MAC address of the custom resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/ipam_ip#mac_address IpamIp#mac_address}
        /// </remarks>
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        string MacAddress
        {
            get;
        }

        /// <summary>When the resource is in a Private Network, a DNS record is available to resolve the resource name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/ipam_ip#name IpamIp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIpamIpCustomResource), fullyQualifiedName: "scaleway.ipamIp.IpamIpCustomResource")]
        internal sealed class _Proxy : DeputyBase, scaleway.IpamIp.IIpamIpCustomResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>MAC address of the custom resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/ipam_ip#mac_address IpamIp#mac_address}
            /// </remarks>
            [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string MacAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>When the resource is in a Private Network, a DNS record is available to resolve the resource name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/ipam_ip#name IpamIp#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
