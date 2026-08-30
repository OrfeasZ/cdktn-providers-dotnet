using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersDriver")]
    public class DomainDevicesControllersDriver : libvirt.Domain.IDomainDevicesControllersDriver
    {
        /// <summary>Controls whether Address Translation Service (ATS) support is enabled for a virtio controller when used with an emulated IOMMU;</summary>
        /// <remarks>
        /// this is a yes/no style boolean (e.g. "on"/"off" or "yes"/"no") depending on hypervisor support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ats
        {
            get;
            set;
        }

        /// <summary>Sets the maximum number of outstanding commands per LUN for SCSI/virtio-scsi controllers;</summary>
        /// <remarks>
        /// value is a positive integer defining the per-LUN queue depth (for example 128, 256).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cmd_per_lun Domain#cmd_per_lun}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cmdPerLun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CmdPerLun
        {
            get;
            set;
        }

        /// <summary>Controls whether ioeventfd is used for the controller to reduce exits between guest and host on I/O operations;</summary>
        /// <remarks>
        /// value is a yes/no style boolean (for example "on"/"off").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_event_fd Domain#io_event_fd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IoEventFd
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of an emulated IOMMU by the controller’s virtio devices;</summary>
        /// <remarks>
        /// value is a yes/no style boolean (for example "on"/"off") and is only meaningful when an IOMMU device is present.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iommu
        {
            get;
            set;
        }

        /// <summary>Assigns the controller to use a specific IOThread by referencing an existing iothread id;</summary>
        /// <remarks>
        /// value is a positive integer matching an IOThread defined in the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread Domain#io_thread}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IoThread
        {
            get;
            set;
        }

        /// <summary>Defines per-IOThread configuration for the controller, allowing multiple IOThreads each with their own queue assignments;</summary>
        /// <remarks>
        /// contents are user-provided and must match defined IOThread ids.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreads", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreads\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersDriverIoThreads? IoThreads
        {
            get;
            set;
        }

        /// <summary>Sets the maximum number of 512-byte sectors that can be transferred in a single I/O request through this controller;</summary>
        /// <remarks>
        /// value is a positive integer tuned for performance and host constraints.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_sectors Domain#max_sectors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxSectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSectors
        {
            get;
            set;
        }

        /// <summary>Controls whether the virtio packed ring layout is used for queues on this controller;</summary>
        /// <remarks>
        /// value is a yes/no style boolean (for example "on"/"off") and requires guest/host support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Packed
        {
            get;
            set;
        }

        /// <summary>Controls whether each virtqueue uses its own memory page (page-per-vq) on this controller;</summary>
        /// <remarks>
        /// value is a yes/no style boolean and is primarily a tuning/compatibility option.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PagePerVq
        {
            get;
            set;
        }

        /// <summary>Specifies the total number of hardware queues for the controller (for example for virtio-scsi or virtio-blk controllers);</summary>
        /// <remarks>
        /// value is a positive integer, often matching the number of vCPUs or IOThreads.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Queues
        {
            get;
            set;
        }
    }
}
