using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceUdp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceUdp")]
    public interface IDomainDevicesInterfacesSourceUdp
    {
        /// <summary>Sets the remote UDP endpoint IP address or hostname for the UDP unicast tunnel backing this interface (user-provided address).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the local (listening) endpoint for a UDP tunnel-backed network interface, enabling the guest-side address/port to be fixed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#local Domain#local}
        /// </remarks>
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdpLocal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceUdpLocal? Local
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the remote UDP port to which the tunnel-backed network interface sends packets;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer (e.g. 5000).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceUdp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceUdp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceUdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the remote UDP endpoint IP address or hostname for the UDP unicast tunnel backing this interface (user-provided address).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the local (listening) endpoint for a UDP tunnel-backed network interface, enabling the guest-side address/port to be fixed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#local Domain#local}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdpLocal\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceUdpLocal? Local
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceUdpLocal?>();
            }

            /// <summary>Sets the remote UDP port to which the tunnel-backed network interface sends packets;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer (e.g. 5000).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
