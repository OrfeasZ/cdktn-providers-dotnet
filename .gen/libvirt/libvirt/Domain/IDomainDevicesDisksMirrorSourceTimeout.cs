using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceTimeout), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceTimeout")]
    public interface IDomainDevicesDisksMirrorSourceTimeout
    {
        /// <summary>Sets the timeout duration in seconds for accessing the mirrored backing-store source; must be a non‑negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#seconds Domain#seconds}
        /// </remarks>
        [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"string\"}")]
        string Seconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceTimeout), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceTimeout")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the timeout duration in seconds for accessing the mirrored backing-store source; must be a non‑negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#seconds Domain#seconds}
            /// </remarks>
            [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"string\"}")]
            public string Seconds
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
