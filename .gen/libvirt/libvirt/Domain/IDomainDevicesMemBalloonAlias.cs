using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemBalloonAlias), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloonAlias")]
    public interface IDomainDevicesMemBalloonAlias
    {
        /// <summary>Sets the alias name used internally by libvirt/qemu to identify this pstore device;</summary>
        /// <remarks>
        /// the value is user-provided and must be unique among device aliases in the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemBalloonAlias), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloonAlias")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemBalloonAlias
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the alias name used internally by libvirt/qemu to identify this pstore device;</summary>
            /// <remarks>
            /// the value is user-provided and must be unique among device aliases in the domain.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
