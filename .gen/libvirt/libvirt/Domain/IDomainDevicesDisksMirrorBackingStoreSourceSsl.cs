using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceSsl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceSsl
    {
        /// <summary>Controls certificate verification for SSL/TLS access to the mirrored backing-store source;</summary>
        /// <remarks>
        /// typical values are "yes" or "no" to enable or disable verification.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#verify Domain#verify}
        /// </remarks>
        [JsiiProperty(name: "verify", typeJson: "{\"primitive\":\"string\"}")]
        string Verify
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceSsl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls certificate verification for SSL/TLS access to the mirrored backing-store source;</summary>
            /// <remarks>
            /// typical values are "yes" or "no" to enable or disable verification.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#verify Domain#verify}
            /// </remarks>
            [JsiiProperty(name: "verify", typeJson: "{\"primitive\":\"string\"}")]
            public string Verify
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
