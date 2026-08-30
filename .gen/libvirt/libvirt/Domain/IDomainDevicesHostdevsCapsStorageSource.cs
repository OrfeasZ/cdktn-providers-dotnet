using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsStorageSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsStorageSource")]
    public interface IDomainDevicesHostdevsCapsStorageSource
    {
        /// <summary>Specifies the path of the host block device used as the storage source for the passthrough device (for example, "/dev/sdb");</summary>
        /// <remarks>
        /// this field is required when configuring caps_storage.source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-character-devices">https://libvirt.org/formatdomain.html#block-character-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"primitive\":\"string\"}")]
        string Block
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsStorageSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsStorageSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsStorageSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the path of the host block device used as the storage source for the passthrough device (for example, "/dev/sdb");</summary>
            /// <remarks>
            /// this field is required when configuring caps_storage.source.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-character-devices">https://libvirt.org/formatdomain.html#block-character-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
            /// </remarks>
            [JsiiProperty(name: "block", typeJson: "{\"primitive\":\"string\"}")]
            public string Block
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
