using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsSmBios), fullyQualifiedName: "libvirt.domain.DomainOsSmBios")]
    public interface IDomainOsSmBios
    {
        /// <summary>Sets the SMBIOS mode, controlling the source of SMBIOS information presented to the guest;</summary>
        /// <remarks>
        /// valid values are driver-specific (commonly host, sysinfo, emulate, or none) and must follow libvirt’s smbios mode semantics.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsSmBios), fullyQualifiedName: "libvirt.domain.DomainOsSmBios")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsSmBios
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SMBIOS mode, controlling the source of SMBIOS information presented to the guest;</summary>
            /// <remarks>
            /// valid values are driver-specific (commonly host, sysinfo, emulate, or none) and must follow libvirt’s smbios mode semantics.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
