using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesDriverGuest), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesDriverGuest")]
    public interface IDomainDevicesInterfacesDriverGuest
    {
        /// <summary>Enables or disables checksum offload as advertised to the guest, controlling whether the guest is expected to handle checksums in software;</summary>
        /// <remarks>
        /// value is typically "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#csum Domain#csum}
        /// </remarks>
        [JsiiProperty(name: "csum", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Csum
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables ECN (Explicit Congestion Notification) offload features as advertised to the guest;</summary>
        /// <remarks>
        /// value is typically "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ecn Domain#ecn}
        /// </remarks>
        [JsiiProperty(name: "ecn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ecn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether TCP segmentation offload (TSO) for IPv4 is enabled on the guest side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tso4 Domain#tso4}
        /// </remarks>
        [JsiiProperty(name: "tso4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tso4
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether TCP segmentation offload (TSO) for IPv6 is enabled on the guest side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tso6 Domain#tso6}
        /// </remarks>
        [JsiiProperty(name: "tso6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tso6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether UDP fragmentation offload (UFO) is enabled on the guest side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ufo Domain#ufo}
        /// </remarks>
        [JsiiProperty(name: "ufo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ufo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesDriverGuest), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesDriverGuest")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesDriverGuest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables or disables checksum offload as advertised to the guest, controlling whether the guest is expected to handle checksums in software;</summary>
            /// <remarks>
            /// value is typically "on" or "off".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#csum Domain#csum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csum", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Csum
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables ECN (Explicit Congestion Notification) offload features as advertised to the guest;</summary>
            /// <remarks>
            /// value is typically "on" or "off".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ecn Domain#ecn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ecn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures whether TCP segmentation offload (TSO) for IPv4 is enabled on the guest side of a virtio network interface driver;</summary>
            /// <remarks>
            /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tso4 Domain#tso4}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tso4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tso4
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures whether TCP segmentation offload (TSO) for IPv6 is enabled on the guest side of a virtio network interface driver;</summary>
            /// <remarks>
            /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tso6 Domain#tso6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tso6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tso6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures whether UDP fragmentation offload (UFO) is enabled on the guest side of a virtio network interface driver;</summary>
            /// <remarks>
            /// value is user-provided, typically a boolean-like “on/off” or “yes/no”.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ufo Domain#ufo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ufo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ufo
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
