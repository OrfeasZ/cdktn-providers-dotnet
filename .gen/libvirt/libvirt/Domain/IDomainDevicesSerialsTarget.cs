using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSerialsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesSerialsTarget")]
    public interface IDomainDevicesSerialsTarget
    {
        /// <summary>Configures the hardware model of the serial port target, allowing selection of different emulated serial controller types where supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTargetModel\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsTargetModel? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the guest-visible serial port number starting from 0;</summary>
        /// <remarks>
        /// typically 0–3 depending on how many serial ports the guest OS supports.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the type of serial controller for this target;</summary>
        /// <remarks>
        /// valid values include "isa-serial", "pci-serial", "usb-serial", "spapr-vty", "sclp-serial", "sclplmconsole", and "system-serial".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSerialsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesSerialsTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSerialsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the hardware model of the serial port target, allowing selection of different emulated serial controller types where supported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTargetModel\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsTargetModel? Model
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsTargetModel?>();
            }

            /// <summary>Sets the guest-visible serial port number starting from 0;</summary>
            /// <remarks>
            /// typically 0–3 depending on how many serial ports the guest OS supports.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Selects the type of serial controller for this target;</summary>
            /// <remarks>
            /// valid values include "isa-serial", "pci-serial", "usb-serial", "spapr-vty", "sclp-serial", "sclplmconsole", and "system-serial".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
