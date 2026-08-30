using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardAddressesPci), fullyQualifiedName: "libvirt.network.NetworkForwardAddressesPci")]
    public interface INetworkForwardAddressesPci
    {
        /// <summary>Sets the PCI bus number (in hexadecimal) of the forwarding device;</summary>
        /// <remarks>
        /// the value must match the host’s PCI topology (e.g. "03").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bus Network#bus}
        /// </remarks>
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Bus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI domain number (in hexadecimal, usually \"0000\") of the forwarding device;</summary>
        /// <remarks>
        /// the value must match the host’s PCI topology.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI function number (in hexadecimal, 0–7) of the forwarding device, completing the BDF identifier.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#function Network#function}
        /// </remarks>
        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Function
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI slot number (in hexadecimal) of the forwarding device;</summary>
        /// <remarks>
        /// together with domain, bus, and function it uniquely identifies the PCI device.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#slot Network#slot}
        /// </remarks>
        [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Slot
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardAddressesPci), fullyQualifiedName: "libvirt.network.NetworkForwardAddressesPci")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardAddressesPci
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the PCI bus number (in hexadecimal) of the forwarding device;</summary>
            /// <remarks>
            /// the value must match the host’s PCI topology (e.g. "03").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#bus Network#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI domain number (in hexadecimal, usually \"0000\") of the forwarding device;</summary>
            /// <remarks>
            /// the value must match the host’s PCI topology.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Domain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI function number (in hexadecimal, 0–7) of the forwarding device, completing the BDF identifier.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#function Network#function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Function
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI slot number (in hexadecimal) of the forwarding device;</summary>
            /// <remarks>
            /// together with domain, bus, and function it uniquely identifies the PCI device.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#slot Network#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Slot
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
