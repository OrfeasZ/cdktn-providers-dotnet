using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceVhostUserSpicePort), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserSpicePort")]
    public interface IDomainDevicesDisksBackingStoreSourceVhostUserSpicePort
    {
        /// <summary>Sets the SPICE channel name used by the EGD RNG backend when the entropy source is a SPICE port;</summary>
        /// <remarks>
        /// the value is user-provided (for example, a named SPICE channel).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channel Domain#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        string Channel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceVhostUserSpicePort), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserSpicePort")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserSpicePort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SPICE channel name used by the EGD RNG backend when the entropy source is a SPICE port;</summary>
            /// <remarks>
            /// the value is user-provided (for example, a named SPICE channel).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channel Domain#channel}
            /// </remarks>
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
            public string Channel
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
