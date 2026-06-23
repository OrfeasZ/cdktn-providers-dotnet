using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceSsl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceSsl")]
    public interface IDomainDevicesDisksMirrorSourceSsl
    {
        /// <summary>Controls certificate verification for SSL/TLS access to the mirrored backing-store source;</summary>
        /// <remarks>
        /// typical values are "yes" or "no" to enable or disable verification.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#verify Domain#verify}
        /// </remarks>
        [JsiiProperty(name: "verify", typeJson: "{\"primitive\":\"string\"}")]
        string Verify
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceSsl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceSsl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceSsl
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#verify Domain#verify}
            /// </remarks>
            [JsiiProperty(name: "verify", typeJson: "{\"primitive\":\"string\"}")]
            public string Verify
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
