using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsIdMapUid), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsIdMapUid")]
    public interface IDomainDevicesFilesystemsIdMapUid
    {
        /// <summary>Sets the size of the GID mapping range (number of consecutive IDs) for this mapping entry;</summary>
        /// <remarks>
        /// must be a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#count Domain#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        /// <summary>Sets the starting host GID to which the guest GID range is mapped; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        double Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsIdMapUid), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsIdMapUid")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsIdMapUid
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the size of the GID mapping range (number of consecutive IDs) for this mapping entry;</summary>
            /// <remarks>
            /// must be a positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#count Domain#count}
            /// </remarks>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the starting host GID to which the guest GID range is mapped; must be a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
            public double Target
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
