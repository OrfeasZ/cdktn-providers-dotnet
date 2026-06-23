using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsBootDevices), fullyQualifiedName: "libvirt.domain.DomainOsBootDevices")]
    public interface IDomainOsBootDevices
    {
        /// <summary>Defines a single boot target device type in the boot order;</summary>
        /// <remarks>
        /// valid values include "hd", "cdrom", "fd", and "network" (and any additional values supported by the hypervisor). Example: "hd".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsBootDevices), fullyQualifiedName: "libvirt.domain.DomainOsBootDevices")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsBootDevices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single boot target device type in the boot order;</summary>
            /// <remarks>
            /// valid values include "hd", "cdrom", "fd", and "network" (and any additional values supported by the hypervisor). Example: "hd".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
