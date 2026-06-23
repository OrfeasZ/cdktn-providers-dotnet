using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsNetSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNetSource")]
    public interface IDomainDevicesHostdevsCapsNetSource
    {
        /// <summary>Specifies the name of the host network interface used as the source for the passthrough network device (for example, "eth0");</summary>
        /// <remarks>
        /// this field is required when configuring caps_net.source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface Domain#interface}
        /// </remarks>
        [JsiiProperty(name: "interface", typeJson: "{\"primitive\":\"string\"}")]
        string Interface
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsNetSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNetSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsNetSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the name of the host network interface used as the source for the passthrough network device (for example, "eth0");</summary>
            /// <remarks>
            /// this field is required when configuring caps_net.source.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface Domain#interface}
            /// </remarks>
            [JsiiProperty(name: "interface", typeJson: "{\"primitive\":\"string\"}")]
            public string Interface
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
