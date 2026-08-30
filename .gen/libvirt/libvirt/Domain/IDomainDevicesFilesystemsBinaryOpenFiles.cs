using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinaryOpenFiles), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles")]
    public interface IDomainDevicesFilesystemsBinaryOpenFiles
    {
        /// <summary>Sets the maximum number of open file descriptors allowed for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is a user-provided positive integer. For example, 1024 or 4096.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max Domain#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinaryOpenFiles), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum number of open file descriptors allowed for the filesystem helper binary;</summary>
            /// <remarks>
            /// value is a user-provided positive integer. For example, 1024 or 4096.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max Domain#max}
            /// </remarks>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
