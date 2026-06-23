using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisks), fullyQualifiedName: "libvirt.domain.DomainDevicesDisks")]
    public interface IDomainDevicesDisks
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksAcpi? Acpi
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
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
        /// <remarks>
        /// include this block only when the target requires authentication.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksAuth? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Attaches the interface’s network backend to a separate driver/backend domain instead of the main host, enabling driver-domain networking setups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend_domain Domain#backend_domain}
        /// </remarks>
        [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackendDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBackendDomain? BackendDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the backing store chain for the mirrored disk image, describing one layer of the underlying image stack used by the mirror target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backing_store Domain#backing_store}
        /// </remarks>
        [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBackingStore? BackingStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per-disk block I/O characteristics such as logical/physical sector sizes and discard granularity as presented to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#block_io Domain#block_io}
        /// </remarks>
        [JsiiProperty(name: "blockIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBlockIo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBlockIo? BlockIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBoot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBoot? Boot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the high-level device type for this disk, typically "disk", "cdrom", "floppy", or "lun";</summary>
        /// <remarks>
        /// the value is user-provided and must be a valid libvirt disk device type.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Device
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures driver-specific options for this disk, such as the hypervisor driver name, cache mode, discard behavior, or I/O bus features.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables disk image encryption configuration for this disk and groups attributes defining the encryption engine, format, and secrets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#encryption Domain#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksEncryption? Encryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the legacy CHS (cylinders/heads/sectors) geometry that the guest sees for this disk, typically for compatibility with older guests or tools.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#geometry Domain#geometry}
        /// </remarks>
        [JsiiProperty(name: "geometry", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksGeometry\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksGeometry? Geometry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per-disk block I/O throttling parameters (bandwidth and IOPS limits, and optional burst limits) for this disk device;</summary>
        /// <remarks>
        /// omit this block to leave disk I/O unthrottled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_tune Domain#io_tune}
        /// </remarks>
        [JsiiProperty(name: "ioTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksIoTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksIoTune? IoTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an online block device mirror for the disk, defining the target image and its properties used during block copy or active commit operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mirror Domain#mirror}
        /// </remarks>
        [JsiiProperty(name: "mirror", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirror\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirror? Mirror
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the emulated disk device model (e.g. "virtio", "scsi", "ide") or a driver-specific model string passed to the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an optional user-provided product identifier string for the disk device, exposed to the guest similar to a SCSI product field.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#product Domain#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Product
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables raw I/O access for the disk device when supported by the driver;</summary>
        /// <remarks>
        /// typically a "yes"/"no" style flag, value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#raw_io Domain#raw_io}
        /// </remarks>
        [JsiiProperty(name: "rawIo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RawIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the disk is exposed as read-only to the guest;</summary>
        /// <remarks>
        /// when set to true the &lt;readonly&gt; element is emitted, and when false or unset the disk is writable.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_only Domain#read_only}
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the user-provided serial number reported to the guest for this disk device (for example, to match a physical disk's serial).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#serial Domain#serial}
        /// </remarks>
        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Serial
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SCSI generic I/O behavior for the disk using a user-provided value accepted by libvirt (e.g. modes controlling filtered vs unfiltered SG_IO).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sgio Domain#sgio}
        /// </remarks>
        [JsiiProperty(name: "sgio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sgio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the disk is marked as shareable between multiple guests;</summary>
        /// <remarks>
        /// when set to true the &lt;shareable&gt; element is emitted, otherwise it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shareable Domain#shareable}
        /// </remarks>
        [JsiiProperty(name: "shareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Shareable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the disk snapshot behavior policy with a user-provided string value supported by libvirt (for example, controlling how the disk participates in domain snapshots).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#snapshot Domain#snapshot}
        /// </remarks>
        [JsiiProperty(name: "snapshot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Snapshot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the guest-visible block device target for this disk, including bus type, device name, and related attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksTarget? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups one or more disk throttle filter references used to apply shared throttling policies via throttle groups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_filters Domain#throttle_filters}
        /// </remarks>
        [JsiiProperty(name: "throttleFilters", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFilters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksThrottleFilters? ThrottleFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Marks this disk as transient, meaning it is not persisted in domain configuration and exists only for the lifetime of the running guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#transient Domain#transient}
        /// </remarks>
        [JsiiProperty(name: "transient", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTransient\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksTransient? Transient
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the vendor identification string reported by this disk to the guest;</summary>
        /// <remarks>
        /// value is user-provided (commonly up to 8 ASCII characters).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
        /// </remarks>
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vendor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the world wide name (WWN) reported for this disk, typically as a 16-hex-digit string (for example "500123456789abcd").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#wwn Domain#wwn}
        /// </remarks>
        [JsiiProperty(name: "wwn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wwn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisks), fullyQualifiedName: "libvirt.domain.DomainDevicesDisks")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksAlias?>();
            }

            /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
            /// <remarks>
            /// include this block only when the target requires authentication.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAuth\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksAuth? Auth
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksAuth?>();
            }

            /// <summary>Attaches the interface’s network backend to a separate driver/backend domain instead of the main host, enabling driver-domain networking setups.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend_domain Domain#backend_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackendDomain\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBackendDomain? BackendDomain
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBackendDomain?>();
            }

            /// <summary>Defines the backing store chain for the mirrored disk image, describing one layer of the underlying image stack used by the mirror target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backing_store Domain#backing_store}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStore\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBackingStore? BackingStore
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBackingStore?>();
            }

            /// <summary>Configures per-disk block I/O characteristics such as logical/physical sector sizes and discard granularity as presented to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#block_io Domain#block_io}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBlockIo\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBlockIo? BlockIo
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBlockIo?>();
            }

            /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#boot Domain#boot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBoot\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBoot? Boot
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBoot?>();
            }

            /// <summary>Selects the high-level device type for this disk, typically "disk", "cdrom", "floppy", or "lun";</summary>
            /// <remarks>
            /// the value is user-provided and must be a valid libvirt disk device type.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Device
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures driver-specific options for this disk, such as the hypervisor driver name, cache mode, discard behavior, or I/O bus features.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksDriver?>();
            }

            /// <summary>Enables disk image encryption configuration for this disk and groups attributes defining the encryption engine, format, and secrets.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#encryption Domain#encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksEncryption\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksEncryption? Encryption
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksEncryption?>();
            }

            /// <summary>Configures the legacy CHS (cylinders/heads/sectors) geometry that the guest sees for this disk, typically for compatibility with older guests or tools.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#geometry Domain#geometry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geometry", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksGeometry\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksGeometry? Geometry
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksGeometry?>();
            }

            /// <summary>Configures per-disk block I/O throttling parameters (bandwidth and IOPS limits, and optional burst limits) for this disk device;</summary>
            /// <remarks>
            /// omit this block to leave disk I/O unthrottled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_tune Domain#io_tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksIoTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksIoTune? IoTune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksIoTune?>();
            }

            /// <summary>Configures an online block device mirror for the disk, defining the target image and its properties used during block copy or active commit operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mirror Domain#mirror}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mirror", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirror\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirror? Mirror
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirror?>();
            }

            /// <summary>Specifies the emulated disk device model (e.g. "virtio", "scsi", "ide") or a driver-specific model string passed to the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an optional user-provided product identifier string for the disk device, exposed to the guest similar to a SCSI product field.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#product Domain#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Product
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables raw I/O access for the disk device when supported by the driver;</summary>
            /// <remarks>
            /// typically a "yes"/"no" style flag, value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#raw_io Domain#raw_io}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rawIo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RawIo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the disk is exposed as read-only to the guest;</summary>
            /// <remarks>
            /// when set to true the &lt;readonly&gt; element is emitted, and when false or unset the disk is writable.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_only Domain#read_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReadOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the user-provided serial number reported to the guest for this disk device (for example, to match a physical disk's serial).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#serial Domain#serial}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Serial
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the SCSI generic I/O behavior for the disk using a user-provided value accepted by libvirt (e.g. modes controlling filtered vs unfiltered SG_IO).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sgio Domain#sgio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sgio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sgio
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the disk is marked as shareable between multiple guests;</summary>
            /// <remarks>
            /// when set to true the &lt;shareable&gt; element is emitted, otherwise it is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shareable Domain#shareable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Shareable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the disk snapshot behavior policy with a user-provided string value supported by libvirt (for example, controlling how the disk participates in domain snapshots).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#snapshot Domain#snapshot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Snapshot
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksSource?>();
            }

            /// <summary>Configures the guest-visible block device target for this disk, including bus type, device name, and related attributes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTarget\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksTarget? Target
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksTarget?>();
            }

            /// <summary>Groups one or more disk throttle filter references used to apply shared throttling policies via throttle groups.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_filters Domain#throttle_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "throttleFilters", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFilters\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksThrottleFilters? ThrottleFilters
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksThrottleFilters?>();
            }

            /// <summary>Marks this disk as transient, meaning it is not persisted in domain configuration and exists only for the lifetime of the running guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#transient Domain#transient}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transient", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTransient\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksTransient? Transient
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksTransient?>();
            }

            /// <summary>Sets the vendor identification string reported by this disk to the guest;</summary>
            /// <remarks>
            /// value is user-provided (commonly up to 8 ASCII characters).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vendor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the world wide name (WWN) reported for this disk, typically as a 16-hex-digit string (for example "500123456789abcd").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#wwn Domain#wwn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wwn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
