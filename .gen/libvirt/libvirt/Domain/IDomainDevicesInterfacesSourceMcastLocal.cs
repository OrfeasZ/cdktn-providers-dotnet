using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceMcastLocal), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceMcastLocal")]
    public interface IDomainDevicesInterfacesSourceMcastLocal
    {
        /// <summary>Sets the local IP address on which the UDP tunnel-backed interface listens;</summary>
        /// <remarks>
        /// value is user-provided (e.g. "0.0.0.0" or a specific host address).
        ///
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

        /// <summary>Sets the local UDP port on which the tunnel-backed interface listens; value is a user-provided non-negative integer (e.g. 5000).</summary>
        /// <remarks>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceMcastLocal), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceMcastLocal")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceMcastLocal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the local IP address on which the UDP tunnel-backed interface listens;</summary>
            /// <remarks>
            /// value is user-provided (e.g. "0.0.0.0" or a specific host address).
            ///
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

            /// <summary>Sets the local UDP port on which the tunnel-backed interface listens; value is a user-provided non-negative integer (e.g. 5000).</summary>
            /// <remarks>
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
