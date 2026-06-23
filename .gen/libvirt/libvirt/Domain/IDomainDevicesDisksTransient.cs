using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksTransient), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksTransient")]
    public interface IDomainDevicesDisksTransient
    {
        /// <summary>Sets whether a transient disk is allowed to share its backing image with other guests; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_backing Domain#share_backing}
        /// </remarks>
        [JsiiProperty(name: "shareBacking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShareBacking
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksTransient), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksTransient")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksTransient
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether a transient disk is allowed to share its backing image with other guests; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_backing Domain#share_backing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareBacking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShareBacking
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
