using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSource), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSource")]
    public interface IDomainDevicesDisksMirrorBackingStoreSource
    {
        /// <summary>Describes a block device used as the source for the mirror backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides optional cookie data associated with the mirror backing store source (for example, auth or session data), with content treated as user-provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cookies Domain#cookies}
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCookies\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies? Cookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ctl Domain#ctl}.</summary>
        [JsiiProperty(name: "ctl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCtl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCtl? Ctl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a data store descriptor for the mirrored backing store, typically used with networked or advanced storage backends that expose format-specific options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#data_store Domain#data_store}
        /// </remarks>
        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore? DataStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a directory-based source for the mirrored backing store, pointing to a host directory used by the backing image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDir\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir? Dir
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables disk image encryption configuration for this disk and groups attributes defining the encryption engine, format, and secrets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#encryption Domain#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption? Encryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a file-based backing store source for the disk mirror, defining how the backing image is accessed from the host filesystem.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the index of this backing store within a backing chain, used when multiple backing layers are present;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Index
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a network-based backing store source (such as NBD, iSCSI, or RBD) for the disk mirror, including authentication and host endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables using an NVMe-backed source for the mirrored disk’s backing store;</summary>
        /// <remarks>
        /// when present, it selects an NVMe device or namespace as the source, with details defined by libvirt/QEMU for NVMe disks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nvme Domain#nvme}
        /// </remarks>
        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNvme\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme? Nvme
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures read-ahead behavior for the mirrored disk’s backing-store source, allowing tuning of how much data is pre-fetched from the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#readahead Domain#readahead}
        /// </remarks>
        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReadahead\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead? Readahead
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures SCSI-style reservations or similar persistent reservation management for the mirrored disk’s backing-store source, controlling how access is coordinated across nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reservations Domain#reservations}
        /// </remarks>
        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations? Reservations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures optional slice or segment information for the backing store source (for example, to describe which logical slices of a device are used);</summary>
        /// <remarks>
        /// content is user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slices Domain#slices}
        /// </remarks>
        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSlices\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices? Slices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables SSL/TLS parameters for accessing the mirrored backing-store source when it is provided over a secure transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ssl Domain#ssl}
        /// </remarks>
        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl? Ssl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies how strictly the mirrored backing-store source must be available during domain startup;</summary>
        /// <remarks>
        /// valid values include "mandatory", "requisite", "optional" (user‑provided string matched by libvirt).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#startup_policy Domain#startup_policy}
        /// </remarks>
        [JsiiProperty(name: "startupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartupPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a timeout for connecting to or initializing the mirrored backing-store source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a vhost-user backend as the transport for the mirrored backing-store source, allowing it to be provided via a userspace process.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost_user Domain#vhost_user}
        /// </remarks>
        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser? VhostUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a vhost-vDPA backend for the disk mirror backing store, allowing acceleration via a vDPA device;</summary>
        /// <remarks>
        /// additional details are determined by libvirt and device configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost_vdpa Domain#vhost_vdpa}
        /// </remarks>
        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa? VhostVdpa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the backingStore source as a libvirt storage volume reference instead of a raw file/block path for the mirrored disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVolume\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSource), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes a block device used as the source for the mirror backing store.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceBlock\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock? Block
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock?>();
            }

            /// <summary>Provides optional cookie data associated with the mirror backing store source (for example, auth or session data), with content treated as user-provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cookies Domain#cookies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCookies\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies? Cookies
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ctl Domain#ctl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ctl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCtl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCtl? Ctl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCtl?>();
            }

            /// <summary>Configures a data store descriptor for the mirrored backing store, typically used with networked or advanced storage backends that expose format-specific options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#data_store Domain#data_store}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStore\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore? DataStore
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore?>();
            }

            /// <summary>Configures a directory-based source for the mirrored backing store, pointing to a host directory used by the backing image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDir\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir? Dir
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir?>();
            }

            /// <summary>Enables disk image encryption configuration for this disk and groups attributes defining the encryption engine, format, and secrets.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#encryption Domain#encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceEncryption\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption? Encryption
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption?>();
            }

            /// <summary>Configures a file-based backing store source for the disk mirror, defining how the backing image is accessed from the host filesystem.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile?>();
            }

            /// <summary>Sets the index of this backing store within a backing chain, used when multiple backing layers are present;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Index
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures a network-based backing store source (such as NBD, iSCSI, or RBD) for the disk mirror, including authentication and host endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetwork\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork? Network
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork?>();
            }

            /// <summary>Enables using an NVMe-backed source for the mirrored disk’s backing store;</summary>
            /// <remarks>
            /// when present, it selects an NVMe device or namespace as the source, with details defined by libvirt/QEMU for NVMe disks.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nvme Domain#nvme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNvme\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme? Nvme
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme?>();
            }

            /// <summary>Configures read-ahead behavior for the mirrored disk’s backing-store source, allowing tuning of how much data is pre-fetched from the backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#readahead Domain#readahead}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReadahead\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead? Readahead
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead?>();
            }

            /// <summary>Configures SCSI-style reservations or similar persistent reservation management for the mirrored disk’s backing-store source, controlling how access is coordinated across nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reservations Domain#reservations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations? Reservations
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations?>();
            }

            /// <summary>Configures optional slice or segment information for the backing store source (for example, to describe which logical slices of a device are used);</summary>
            /// <remarks>
            /// content is user-provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slices Domain#slices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSlices\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices? Slices
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices?>();
            }

            /// <summary>Enables SSL/TLS parameters for accessing the mirrored backing-store source when it is provided over a secure transport.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ssl Domain#ssl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl? Ssl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl?>();
            }

            /// <summary>Specifies how strictly the mirrored backing-store source must be available during domain startup;</summary>
            /// <remarks>
            /// valid values include "mandatory", "requisite", "optional" (user‑provided string matched by libvirt).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#startup_policy Domain#startup_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartupPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures a timeout for connecting to or initializing the mirrored backing-store source.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceTimeout\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout? Timeout
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout?>();
            }

            /// <summary>Selects a vhost-user backend as the transport for the mirrored backing-store source, allowing it to be provided via a userspace process.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost_user Domain#vhost_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUser\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser? VhostUser
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser?>();
            }

            /// <summary>Selects a vhost-vDPA backend for the disk mirror backing store, allowing acceleration via a vDPA device;</summary>
            /// <remarks>
            /// additional details are determined by libvirt and device configuration.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vhost_vdpa Domain#vhost_vdpa}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa? VhostVdpa
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa?>();
            }

            /// <summary>Configures the backingStore source as a libvirt storage volume reference instead of a raw file/block path for the mirrored disk.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVolume\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume? Volume
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume?>();
            }
        }
    }
}
