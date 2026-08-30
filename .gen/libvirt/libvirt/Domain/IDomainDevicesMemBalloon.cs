using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemBalloon), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloon")]
    public interface IDomainDevicesMemBalloon
    {
        /// <summary>Sets the balloon device model, commonly virtio for QEMU/KVM;</summary>
        /// <remarks>
        /// value is user-provided and must be supported by the hypervisor (for example, "virtio").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        string Model
        {
            get;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloonAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloonAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloonAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables automatic deflation of the balloon to return memory to the guest when it is needed, using a yes/no string flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto_deflate Domain#auto_deflate}
        /// </remarks>
        [JsiiProperty(name: "autoDeflate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoDeflate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures driver-specific options for the memory balloon’s virtio transport, such as IOMMU and ATS behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloonDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables free page reporting for the balloon device, allowing the guest to report unused pages back to the host, using a yes/no string flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#free_page_reporting Domain#free_page_reporting}
        /// </remarks>
        [JsiiProperty(name: "freePageReporting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FreePageReporting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures collection of balloon statistics such as how often the host polls the guest for memory usage information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#stats Domain#stats}
        /// </remarks>
        [JsiiProperty(name: "stats", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonStats\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloonStats? Stats
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemBalloon), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloon")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemBalloon
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the balloon device model, commonly virtio for QEMU/KVM;</summary>
            /// <remarks>
            /// value is user-provided and must be supported by the hypervisor (for example, "virtio").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
            public string Model
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloonAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloonAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloonAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloonAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloonAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloonAlias?>();
            }

            /// <summary>Enables or disables automatic deflation of the balloon to return memory to the guest when it is needed, using a yes/no string flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto_deflate Domain#auto_deflate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoDeflate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoDeflate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures driver-specific options for the memory balloon’s virtio transport, such as IOMMU and ATS behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloonDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloonDriver?>();
            }

            /// <summary>Enables or disables free page reporting for the balloon device, allowing the guest to report unused pages back to the host, using a yes/no string flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#free_page_reporting Domain#free_page_reporting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freePageReporting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FreePageReporting
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures collection of balloon statistics such as how often the host polls the guest for memory usage information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#stats Domain#stats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stats", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloonStats\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloonStats? Stats
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloonStats?>();
            }
        }
    }
}
