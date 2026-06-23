using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVsockCid), fullyQualifiedName: "libvirt.domain.DomainDevicesVsockCid")]
    public interface IDomainDevicesVsockCid
    {
        /// <summary>Sets a fixed 32‑bit vsock context ID (CID) value to be used by the guest;</summary>
        /// <remarks>
        /// the value is user‑provided and must be valid for the chosen vsock backend (for example, a positive integer like 3).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
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

        /// <summary>Controls whether the vsock CID is assigned automatically;</summary>
        /// <remarks>
        /// when set (typically "yes"/"no"), libvirt or the hypervisor chooses an appropriate CID if automatic assignment is enabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auto Domain#auto}
        /// </remarks>
        [JsiiProperty(name: "auto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Auto
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVsockCid), fullyQualifiedName: "libvirt.domain.DomainDevicesVsockCid")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVsockCid
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets a fixed 32‑bit vsock context ID (CID) value to be used by the guest;</summary>
            /// <remarks>
            /// the value is user‑provided and must be valid for the chosen vsock backend (for example, a positive integer like 3).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the vsock CID is assigned automatically;</summary>
            /// <remarks>
            /// when set (typically "yes"/"no"), libvirt or the hypervisor chooses an appropriate CID if automatic assignment is enabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auto Domain#auto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Auto
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
