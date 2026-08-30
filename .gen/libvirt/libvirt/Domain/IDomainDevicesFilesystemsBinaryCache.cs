using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinaryCache), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryCache")]
    public interface IDomainDevicesFilesystemsBinaryCache
    {
        /// <summary>Sets the cache mode policy for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is user-provided and should match libvirt's supported cache modes (for example, "always", "none", or similar driver-specific values).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinaryCache), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryCache")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinaryCache
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the cache mode policy for the filesystem helper binary;</summary>
            /// <remarks>
            /// value is user-provided and should match libvirt's supported cache modes (for example, "always", "none", or similar driver-specific values).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
