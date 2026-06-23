using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm
    {
        /// <summary>Sets the master side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0A);</summary>
        /// <remarks>
        /// this attribute is required for an nmdm source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#master Domain#master}
        /// </remarks>
        [JsiiProperty(name: "master", typeJson: "{\"primitive\":\"string\"}")]
        string Master
        {
            get;
        }

        /// <summary>Sets the slave side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0B);</summary>
        /// <remarks>
        /// this attribute is required for an nmdm source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#slave Domain#slave}
        /// </remarks>
        [JsiiProperty(name: "slave", typeJson: "{\"primitive\":\"string\"}")]
        string Slave
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the master side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0A);</summary>
            /// <remarks>
            /// this attribute is required for an nmdm source.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#master Domain#master}
            /// </remarks>
            [JsiiProperty(name: "master", typeJson: "{\"primitive\":\"string\"}")]
            public string Master
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the slave side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0B);</summary>
            /// <remarks>
            /// this attribute is required for an nmdm source.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#slave Domain#slave}
            /// </remarks>
            [JsiiProperty(name: "slave", typeJson: "{\"primitive\":\"string\"}")]
            public string Slave
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
