using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceDirect), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceDirect")]
    public interface IDomainDevicesInterfacesSourceDirect
    {
        /// <summary>Sets the name of the host network interface (e.g. `eth0`, `eno1`) that is directly attached to the guest via a macvtap “direct” interface.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the direct attachment mode for a macvtap “direct” interface;</summary>
        /// <remarks>
        /// valid values are user-provided strings such as <c>vepa</c>, <c>bridge</c>, <c>private</c>, or <c>passthrough</c> as supported by libvirt/qemu.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceDirect), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceDirect")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceDirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the host network interface (e.g. `eth0`, `eno1`) that is directly attached to the guest via a macvtap “direct” interface.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dev
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the direct attachment mode for a macvtap “direct” interface;</summary>
            /// <remarks>
            /// valid values are user-provided strings such as <c>vepa</c>, <c>bridge</c>, <c>private</c>, or <c>passthrough</c> as supported by libvirt/qemu.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
