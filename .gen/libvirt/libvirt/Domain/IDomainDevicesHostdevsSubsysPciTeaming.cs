using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysPciTeaming), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming")]
    public interface IDomainDevicesHostdevsSubsysPciTeaming
    {
        /// <summary>Sets the teaming mode for this hostdev (for example "persistent" or "transient") and is required when teaming is configured;</summary>
        /// <remarks>
        /// valid values are those supported by libvirt for teaming type.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair">https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Controls whether the teaming configuration for this hostdev should survive guest reboots;</summary>
        /// <remarks>
        /// when true, the team is kept persistent, when false it is transient for the current guest lifecycle.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair">https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#persistent Domain#persistent}
        /// </remarks>
        [JsiiProperty(name: "persistent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Persistent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysPciTeaming), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the teaming mode for this hostdev (for example "persistent" or "transient") and is required when teaming is configured;</summary>
            /// <remarks>
            /// valid values are those supported by libvirt for teaming type.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair">https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Controls whether the teaming configuration for this hostdev should survive guest reboots;</summary>
            /// <remarks>
            /// when true, the team is kept persistent, when false it is transient for the current guest lifecycle.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair">https://libvirt.org/formatdomain.html#teaming-a-virtio-hostdev-nic-pair</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#persistent Domain#persistent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Persistent
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
