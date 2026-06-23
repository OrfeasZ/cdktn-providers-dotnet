using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInputsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsSource")]
    public interface IDomainDevicesInputsSource
    {
        /// <summary>Attaches the input device to a host evdev device node, allowing direct passthrough of events from that device to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ev_dev Domain#ev_dev}
        /// </remarks>
        [JsiiProperty(name: "evDev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourceEvDev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInputsSourceEvDev? EvDev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the input device as a passthrough device using a host evdev path, allowing low-level event forwarding directly to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourcePassthrough\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInputsSourcePassthrough? Passthrough
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInputsSource), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInputsSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Attaches the input device to a host evdev device node, allowing direct passthrough of events from that device to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ev_dev Domain#ev_dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evDev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourceEvDev\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInputsSourceEvDev? EvDev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInputsSourceEvDev?>();
            }

            /// <summary>Configures the input device as a passthrough device using a host evdev path, allowing low-level event forwarding directly to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourcePassthrough\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInputsSourcePassthrough? Passthrough
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInputsSourcePassthrough?>();
            }
        }
    }
}
