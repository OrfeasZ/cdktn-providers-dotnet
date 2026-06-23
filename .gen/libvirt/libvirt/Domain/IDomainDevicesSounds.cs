using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSounds), fullyQualifiedName: "libvirt.domain.DomainDevicesSounds")]
    public interface IDomainDevicesSounds
    {
        /// <summary>Sets the emulated sound card model presented to the guest;</summary>
        /// <remarks>
        /// valid values include "ac97", "es1370", "sb16", "ich6", "ich7", "ich9", "pcspk", and "virtio".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        string Model
        {
            get;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSoundsAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSoundsAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSoundsAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Associates the sound device with a specific host audio backend instance (by ID) when multiple audio backends are defined.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audio Domain#audio}
        /// </remarks>
        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAudio\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSoundsAudio? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the audio codec parameters for the sound device;</summary>
        /// <remarks>
        /// contents and allowed values depend on the selected model and hypervisor support.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#codec Domain#codec}
        /// </remarks>
        [JsiiProperty(name: "codec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSoundsCodec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Codec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures virtio transport–related driver options for virtio-based sound devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSoundsDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets whether the emulated sound device exposes multichannel audio support;</summary>
        /// <remarks>
        /// accepts a boolean-like value (for example, "on"/"off" or "yes"/"no") as supported by the chosen sound model and hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_channel Domain#multi_channel}
        /// </remarks>
        [JsiiProperty(name: "multiChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiChannel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum number of simultaneous audio streams the sound device can handle;</summary>
        /// <remarks>
        /// value is user-provided and must be a non-negative integer supported by the selected sound model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#streams Domain#streams}
        /// </remarks>
        [JsiiProperty(name: "streams", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Streams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSounds), fullyQualifiedName: "libvirt.domain.DomainDevicesSounds")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSounds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the emulated sound card model presented to the guest;</summary>
            /// <remarks>
            /// valid values include "ac97", "es1370", "sb16", "ich6", "ich7", "ich9", "pcspk", and "virtio".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
            public string Model
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSoundsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSoundsAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSoundsAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSoundsAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSoundsAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSoundsAlias?>();
            }

            /// <summary>Associates the sound device with a specific host audio backend instance (by ID) when multiple audio backends are defined.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audio Domain#audio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsAudio\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSoundsAudio? Audio
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSoundsAudio?>();
            }

            /// <summary>Configures the audio codec parameters for the sound device;</summary>
            /// <remarks>
            /// contents and allowed values depend on the selected model and hypervisor support.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#codec Domain#codec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSoundsCodec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Codec
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures virtio transport–related driver options for virtio-based sound devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSoundsDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSoundsDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSoundsDriver?>();
            }

            /// <summary>Sets whether the emulated sound device exposes multichannel audio support;</summary>
            /// <remarks>
            /// accepts a boolean-like value (for example, "on"/"off" or "yes"/"no") as supported by the chosen sound model and hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_channel Domain#multi_channel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiChannel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the maximum number of simultaneous audio streams the sound device can handle;</summary>
            /// <remarks>
            /// value is user-provided and must be a non-negative integer supported by the selected sound model.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#streams Domain#streams}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streams", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Streams
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
