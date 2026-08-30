using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsMiscSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsMiscSource")]
    public interface IDomainDevicesHostdevsCapsMiscSource
    {
        /// <summary>Specifies a character-device style source (for example, a host chardev path) used by the miscellaneous capability;</summary>
        /// <remarks>
        /// the value is a user-provided device path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-character-devices">https://libvirt.org/formatdomain.html#block-character-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#char Domain#char}
        /// </remarks>
        [JsiiProperty(name: "char", typeJson: "{\"primitive\":\"string\"}")]
        string Char
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsMiscSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsMiscSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsMiscSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies a character-device style source (for example, a host chardev path) used by the miscellaneous capability;</summary>
            /// <remarks>
            /// the value is a user-provided device path.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-character-devices">https://libvirt.org/formatdomain.html#block-character-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#char Domain#char}
            /// </remarks>
            [JsiiProperty(name: "char", typeJson: "{\"primitive\":\"string\"}")]
            public string Char
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
