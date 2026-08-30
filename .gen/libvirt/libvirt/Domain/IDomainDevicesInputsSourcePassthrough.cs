using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInputsSourcePassthrough), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsSourcePassthrough")]
    public interface IDomainDevicesInputsSourcePassthrough
    {
        /// <summary>Specifies the mandatory path to the host evdev device node used for passthrough (for example, "/dev/input/event5");</summary>
        /// <remarks>
        /// the value is a user-provided absolute device path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ev_dev Domain#ev_dev}
        /// </remarks>
        [JsiiProperty(name: "evDev", typeJson: "{\"primitive\":\"string\"}")]
        string EvDev
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInputsSourcePassthrough), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsSourcePassthrough")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInputsSourcePassthrough
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the mandatory path to the host evdev device node used for passthrough (for example, "/dev/input/event5");</summary>
            /// <remarks>
            /// the value is a user-provided absolute device path.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ev_dev Domain#ev_dev}
            /// </remarks>
            [JsiiProperty(name: "evDev", typeJson: "{\"primitive\":\"string\"}")]
            public string EvDev
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
