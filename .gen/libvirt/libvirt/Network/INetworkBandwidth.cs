using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkBandwidth), fullyQualifiedName: "libvirt.network.NetworkBandwidth")]
    public interface INetworkBandwidth
    {
        /// <summary>Sets an optional traffic classification identifier (classID) for the network's bandwidth rules;</summary>
        /// <remarks>
        /// value is user-provided and format is not constrained by libvirt.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#class_id Network#class_id}
        /// </remarks>
        [JsiiProperty(name: "classId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClassId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QoS limits for outgoing traffic from the network, with child attributes controlling average rate and related parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#inbound Network#inbound}
        /// </remarks>
        [JsiiProperty(name: "inbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthInbound\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkBandwidthInbound? Inbound
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QoS limits for outgoing traffic from the network, with child attributes controlling average rate and related parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#outbound Network#outbound}
        /// </remarks>
        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthOutbound\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkBandwidthOutbound? Outbound
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkBandwidth), fullyQualifiedName: "libvirt.network.NetworkBandwidth")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkBandwidth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets an optional traffic classification identifier (classID) for the network's bandwidth rules;</summary>
            /// <remarks>
            /// value is user-provided and format is not constrained by libvirt.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#class_id Network#class_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "classId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClassId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures QoS limits for outgoing traffic from the network, with child attributes controlling average rate and related parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#inbound Network#inbound}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthInbound\"}", isOptional: true)]
            public libvirt.Network.INetworkBandwidthInbound? Inbound
            {
                get => GetInstanceProperty<libvirt.Network.INetworkBandwidthInbound?>();
            }

            /// <summary>Configures QoS limits for outgoing traffic from the network, with child attributes controlling average rate and related parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#outbound Network#outbound}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthOutbound\"}", isOptional: true)]
            public libvirt.Network.INetworkBandwidthOutbound? Outbound
            {
                get => GetInstanceProperty<libvirt.Network.INetworkBandwidthOutbound?>();
            }
        }
    }
}
