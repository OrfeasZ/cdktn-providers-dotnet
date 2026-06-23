using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSource")]
    public class DomainOsNvRamSource : libvirt.Domain.IDomainOsNvRamSource
    {
        /// <summary>Describes a block device used as the source for the mirror backing store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#block Domain#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceBlock\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceBlock? Block
        {
            get;
            set;
        }

        /// <summary>Provides optional cookie data associated with the mirror backing store source (for example, auth or session data), with content treated as user-provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cookies Domain#cookies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceCookies\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceCookies? Cookies
        {
            get;
            set;
        }

        /// <summary>Configures a data store descriptor for the mirrored backing store, typically used with networked or advanced storage backends that expose format-specific options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#data_store Domain#data_store}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStore\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceDataStore? DataStore
        {
            get;
            set;
        }

        /// <summary>Configures a directory-based source for the mirrored backing store, pointing to a host directory used by the backing image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDir\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceDir? Dir
        {
            get;
            set;
        }

        /// <summary>Enables disk image encryption configuration for this disk and groups attributes defining the encryption engine, format, and secrets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#encryption Domain#encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceEncryption\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceEncryption? Encryption
        {
            get;
            set;
        }

        /// <summary>Configures a file-based backing store source for the disk mirror, defining how the backing image is accessed from the host filesystem.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceFile? File
        {
            get;
            set;
        }

        /// <summary>Sets the index of this backing store within a backing chain, used when multiple backing layers are present;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Index
        {
            get;
            set;
        }

        /// <summary>Configures a network-based backing store source (such as NBD, iSCSI, or RBD) for the disk mirror, including authentication and host endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetwork\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceNetwork? Network
        {
            get;
            set;
        }

        /// <summary>Enables using an NVMe-backed source for the mirrored disk’s backing store;</summary>
        /// <remarks>
        /// when present, it selects an NVMe device or namespace as the source, with details defined by libvirt/QEMU for NVMe disks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nvme Domain#nvme}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNvme\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceNvme? Nvme
        {
            get;
            set;
        }

        /// <summary>Configures read-ahead behavior for the mirrored disk’s backing-store source, allowing tuning of how much data is pre-fetched from the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#readahead Domain#readahead}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReadahead\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceReadahead? Readahead
        {
            get;
            set;
        }

        /// <summary>Configures SCSI-style reservations or similar persistent reservation management for the mirrored disk’s backing-store source, controlling how access is coordinated across nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reservations Domain#reservations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservations\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceReservations? Reservations
        {
            get;
            set;
        }

        /// <summary>Configures optional slice or segment information for the backing store source (for example, to describe which logical slices of a device are used);</summary>
        /// <remarks>
        /// content is user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#slices Domain#slices}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSlices\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceSlices? Slices
        {
            get;
            set;
        }

        /// <summary>Enables SSL/TLS parameters for accessing the mirrored backing-store source when it is provided over a secure transport.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ssl Domain#ssl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSsl\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceSsl? Ssl
        {
            get;
            set;
        }

        /// <summary>Specifies how strictly the mirrored backing-store source must be available during domain startup;</summary>
        /// <remarks>
        /// valid values include "mandatory", "requisite", "optional" (user‑provided string matched by libvirt).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#startup_policy Domain#startup_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartupPolicy
        {
            get;
            set;
        }

        /// <summary>Configures a timeout for connecting to or initializing the mirrored backing-store source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceTimeout\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceTimeout? Timeout
        {
            get;
            set;
        }

        /// <summary>Selects a vhost-user backend as the transport for the mirrored backing-store source, allowing it to be provided via a userspace process.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vhost_user Domain#vhost_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUser\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceVhostUser? VhostUser
        {
            get;
            set;
        }

        /// <summary>Selects a vhost-vDPA backend for the disk mirror backing store, allowing acceleration via a vDPA device;</summary>
        /// <remarks>
        /// additional details are determined by libvirt and device configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vhost_vdpa Domain#vhost_vdpa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostVdpa\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceVhostVdpa? VhostVdpa
        {
            get;
            set;
        }

        /// <summary>Configures the backingStore source as a libvirt storage volume reference instead of a raw file/block path for the mirrored disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVolume\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceVolume? Volume
        {
            get;
            set;
        }
    }
}
