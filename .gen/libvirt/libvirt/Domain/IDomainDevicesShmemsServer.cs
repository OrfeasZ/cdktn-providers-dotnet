using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesShmemsServer), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsServer")]
    public interface IDomainDevicesShmemsServer
    {
        /// <summary>Sets the filesystem path used by the shmem server (for example, a memory-backend or socket path) as a user-provided string.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesShmemsServer), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsServer")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesShmemsServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the filesystem path used by the shmem server (for example, a memory-backend or socket path) as a user-provided string.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
