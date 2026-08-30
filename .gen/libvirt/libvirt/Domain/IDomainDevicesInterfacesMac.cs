using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesMac), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesMac")]
    public interface IDomainDevicesInterfacesMac
    {
        /// <summary>Sets the MAC address of the NIC as a 6-byte hexadecimal address string (for example, "52:54:00:ab:cd:ef");</summary>
        /// <remarks>
        /// must be unique per interface on the same network.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Controls how libvirt handles MAC address conflicts for this NIC;</summary>
        /// <remarks>
        /// valid values are implementation-defined strings such as "none" or "duplicate" where supported, and are user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#check Domain#check}
        /// </remarks>
        [JsiiProperty(name: "check", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Check
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the MAC address type for the interface; value is user-provided (for example, vendor-specific type strings) and is optional.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesMac), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesMac")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesMac
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the MAC address of the NIC as a 6-byte hexadecimal address string (for example, "52:54:00:ab:cd:ef");</summary>
            /// <remarks>
            /// must be unique per interface on the same network.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Controls how libvirt handles MAC address conflicts for this NIC;</summary>
            /// <remarks>
            /// valid values are implementation-defined strings such as "none" or "duplicate" where supported, and are user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#check Domain#check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "check", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Check
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the MAC address type for the interface; value is user-provided (for example, vendor-specific type strings) and is optional.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
