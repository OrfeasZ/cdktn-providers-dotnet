using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinarySandbox), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinarySandbox")]
    public interface IDomainDevicesFilesystemsBinarySandbox
    {
        /// <summary>Sets the sandbox mode for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is user-provided and should match one of libvirt's supported sandbox modes for this backend. For example, a mode could indicate "chroot" or "none" depending on driver support.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinarySandbox), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinarySandbox")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the sandbox mode for the filesystem helper binary;</summary>
            /// <remarks>
            /// value is user-provided and should match one of libvirt's supported sandbox modes for this backend. For example, a mode could indicate "chroot" or "none" depending on driver support.
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
