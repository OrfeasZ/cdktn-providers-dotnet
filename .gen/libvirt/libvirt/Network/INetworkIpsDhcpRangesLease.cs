using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkIpsDhcpRangesLease), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpRangesLease")]
    public interface INetworkIpsDhcpRangesLease
    {
        /// <summary>Sets the DHCP lease time for a static host entry, as a numeric duration value whose interpretation depends on `unit` (for example, `3600` when `unit` is `seconds`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#expiry Network#expiry}
        /// </remarks>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"number\"}")]
        double Expiry
        {
            get;
        }

        /// <summary>Sets the time unit used for the host DHCP lease `expiry`, with valid values `seconds`, `minutes`, or `hours`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#unit Network#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkIpsDhcpRangesLease), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpRangesLease")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkIpsDhcpRangesLease
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the DHCP lease time for a static host entry, as a numeric duration value whose interpretation depends on `unit` (for example, `3600` when `unit` is `seconds`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#expiry Network#expiry}
            /// </remarks>
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"number\"}")]
            public double Expiry
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the time unit used for the host DHCP lease `expiry`, with valid values `seconds`, `minutes`, or `hours`.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#unit Network#unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
