using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinaryLock), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryLock")]
    public interface IDomainDevicesFilesystemsBinaryLock
    {
        /// <summary>Enables or disables use of flock-style locking by the filesystem helper binary;</summary>
        /// <remarks>
        /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#flock Domain#flock}
        /// </remarks>
        [JsiiProperty(name: "flock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Flock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables use of POSIX locks by the filesystem helper binary;</summary>
        /// <remarks>
        /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#posix Domain#posix}
        /// </remarks>
        [JsiiProperty(name: "posix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Posix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinaryLock), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryLock")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinaryLock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables or disables use of flock-style locking by the filesystem helper binary;</summary>
            /// <remarks>
            /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#flock Domain#flock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Flock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables use of POSIX locks by the filesystem helper binary;</summary>
            /// <remarks>
            /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#posix Domain#posix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "posix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Posix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
