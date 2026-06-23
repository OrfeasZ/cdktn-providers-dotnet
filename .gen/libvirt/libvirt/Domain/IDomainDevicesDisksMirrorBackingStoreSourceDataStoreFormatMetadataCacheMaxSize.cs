using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize
    {
        /// <summary>Sets the numeric value for the metadata cache maximum size in the specified unit;</summary>
        /// <remarks>
        /// this must be a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>Sets the unit used for the metadata cache maximum size;</summary>
        /// <remarks>
        /// valid units follow libvirt size units such as "B", "KiB", "MiB", "GiB" and are user-chosen.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unit Domain#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the numeric value for the metadata cache maximum size in the specified unit;</summary>
            /// <remarks>
            /// this must be a positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the unit used for the metadata cache maximum size;</summary>
            /// <remarks>
            /// valid units follow libvirt size units such as "B", "KiB", "MiB", "GiB" and are user-chosen.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#unit Domain#unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
