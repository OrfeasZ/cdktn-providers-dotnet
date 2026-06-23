using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkIpsDhcpRanges), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpRanges")]
    public interface INetworkIpsDhcpRanges
    {
        /// <summary>Sets the end address (inclusive) of a DHCP range;</summary>
        /// <remarks>
        /// must be an IP in the same subnet as the parent <c>ip</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#end Network#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the lease parameters for this static DHCP host entry, such as expiry; the structure and values are user-provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#lease Network#lease}
        /// </remarks>
        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLease\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkIpsDhcpRangesLease? Lease
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the starting address of a DHCP range;</summary>
        /// <remarks>
        /// must be an IP in the same subnet as the parent <c>ip</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#start Network#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkIpsDhcpRanges), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpRanges")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkIpsDhcpRanges
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the end address (inclusive) of a DHCP range;</summary>
            /// <remarks>
            /// must be an IP in the same subnet as the parent <c>ip</c>.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#end Network#end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? End
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the lease parameters for this static DHCP host entry, such as expiry; the structure and values are user-provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#lease Network#lease}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLease\"}", isOptional: true)]
            public libvirt.Network.INetworkIpsDhcpRangesLease? Lease
            {
                get => GetInstanceProperty<libvirt.Network.INetworkIpsDhcpRangesLease?>();
            }

            /// <summary>Sets the starting address of a DHCP range;</summary>
            /// <remarks>
            /// must be an IP in the same subnet as the parent <c>ip</c>.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#start Network#start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Start
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
