using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinaryThreadPool), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool")]
    public interface IDomainDevicesFilesystemsBinaryThreadPool
    {
        /// <summary>Sets the number of worker threads in the filesystem helper binary's thread pool;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer. For example, 4 or 16.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinaryThreadPool), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the number of worker threads in the filesystem helper binary's thread pool;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer. For example, 4 or 16.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
