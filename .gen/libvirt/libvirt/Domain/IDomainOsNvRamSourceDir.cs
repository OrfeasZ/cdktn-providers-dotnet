using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceDir), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceDir")]
    public interface IDomainOsNvRamSourceDir
    {
        /// <summary>Sets the host directory path used as the mirrored backing store source;</summary>
        /// <remarks>
        /// this must be an absolute path on the host (for example, "/var/lib/libvirt/images").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dir
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceDir), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceDir")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceDir
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host directory path used as the mirrored backing store source;</summary>
            /// <remarks>
            /// this must be an absolute path on the host (for example, "/var/lib/libvirt/images").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dir
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
