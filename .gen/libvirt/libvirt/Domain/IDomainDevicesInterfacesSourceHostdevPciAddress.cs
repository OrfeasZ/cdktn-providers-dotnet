using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevPciAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddress")]
    public interface IDomainDevicesInterfacesSourceHostdevPciAddress
    {
        /// <summary>Sets the PCI bus number of the host device to passthrough;</summary>
        /// <remarks>
        /// the value is usually a hexadecimal or decimal bus index matching the host's PCI topology (for example, "0x03").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
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

        /// <summary>Sets the PCI domain number of the host device (segment), typically "0" on most systems;</summary>
        /// <remarks>
        /// the value must match the device's domain as reported by tools like lspci.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#domain Domain#domain}
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

        /// <summary>Sets the PCI function number of the host device (0–7), usually provided as a small integer or hex string (for example, "0" or "0x0") corresponding to the device's function.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#function Domain#function}
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

        /// <summary>Indicates whether the PCI device is part of a multifunction PCI slot; accepts "on"/"off" as yes/no flags.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_function Domain#multi_function}
        /// </remarks>
        [JsiiProperty(name: "multiFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI slot number of the host device, usually as a hex or decimal value (for example, "0x00" or "0") matching the slot shown by lspci.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#slot Domain#slot}
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

        /// <summary>Groups additional addressing attributes for s390x zPCI devices, used when passing through PCI devices on IBM Z systems.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#zpci Domain#zpci}
        /// </remarks>
        [JsiiProperty(name: "zpci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci? Zpci
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevPciAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the PCI bus number of the host device to passthrough;</summary>
            /// <remarks>
            /// the value is usually a hexadecimal or decimal bus index matching the host's PCI topology (for example, "0x03").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI domain number of the host device (segment), typically "0" on most systems;</summary>
            /// <remarks>
            /// the value must match the device's domain as reported by tools like lspci.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#domain Domain#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Domain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI function number of the host device (0–7), usually provided as a small integer or hex string (for example, "0" or "0x0") corresponding to the device's function.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#function Domain#function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Function
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates whether the PCI device is part of a multifunction PCI slot; accepts "on"/"off" as yes/no flags.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_function Domain#multi_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiFunction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the PCI slot number of the host device, usually as a hex or decimal value (for example, "0x00" or "0") matching the slot shown by lspci.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#slot Domain#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Slot
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Groups additional addressing attributes for s390x zPCI devices, used when passing through PCI devices on IBM Z systems.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#zpci Domain#zpci}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zpci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci? Zpci
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci?>();
            }
        }
    }
}
