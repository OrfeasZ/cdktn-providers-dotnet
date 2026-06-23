using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesDriver")]
    public class DomainDevicesInterfacesDriver : libvirt.Domain.IDomainDevicesInterfacesDriver
    {
        /// <summary>Enables or disables Address Translation Service (ATS) for a virtio interface when used with an emulated IOMMU;</summary>
        /// <remarks>
        /// value is typically "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ats
        {
            get;
            set;
        }

        /// <summary>Enables or disables virtio event index optimization for this interface; value is typically "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#event_idx Domain#event_idx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventIdx", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventIdx
        {
            get;
            set;
        }

        /// <summary>Configures guest‑visible offload capabilities advertised by this interface’s driver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#guest Domain#guest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverGuest\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesDriverGuest? Guest
        {
            get;
            set;
        }

        /// <summary>Groups driver-specific offload and tuning options that apply to the host side of a virtio network interface;</summary>
        /// <remarks>
        /// individual attributes within this block are user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverHost\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesDriverHost? Host
        {
            get;
            set;
        }

        /// <summary>Configures whether ioeventfd is used for the virtio network interface, enabling eventfd-based notification for I/O;</summary>
        /// <remarks>
        /// value is user-provided, usually a boolean-like “on/off”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_event_fd Domain#io_event_fd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IoEventFd
        {
            get;
            set;
        }

        /// <summary>Configures whether the virtio network device uses an emulated IOMMU for DMA translation;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iommu
        {
            get;
            set;
        }

        /// <summary>Sets the driver name/type for the network interface backend (for example, a specific vhost or virtio implementation);</summary>
        /// <remarks>
        /// value is user-provided string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Configures whether the virtio network interface uses packed virtqueue format instead of split queues;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Packed
        {
            get;
            set;
        }

        /// <summary>Configures whether each virtqueue of the virtio network interface uses a dedicated page (page_per_vq);</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PagePerVq
        {
            get;
            set;
        }

        /// <summary>Sets the number of virtio queues for the network interface to support multiqueue networking;</summary>
        /// <remarks>
        /// value is user-provided positive integer (for example, 4 or 8).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Queues
        {
            get;
            set;
        }

        /// <summary>Configures whether Receive Side Scaling (RSS) is enabled for the virtio network interface, distributing traffic across multiple queues;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rss Domain#rss}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rss", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Rss
        {
            get;
            set;
        }

        /// <summary>Configures whether the virtio network interface reports RSS hash information to the guest;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rss_hash_report Domain#rss_hash_report}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rssHashReport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RssHashReport
        {
            get;
            set;
        }

        /// <summary>Sets the size (number of descriptors) of the receive queue for the virtio network interface;</summary>
        /// <remarks>
        /// value is user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rx_queue_size Domain#rx_queue_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rxQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RxQueueSize
        {
            get;
            set;
        }

        /// <summary>Sets the transmit mode for a virtio network interface driver;</summary>
        /// <remarks>
        /// valid values are user-provided but typically include modes like 'iothread' or 'timer' depending on QEMU support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tx_mode Domain#tx_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "txMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TxMode
        {
            get;
            set;
        }

        /// <summary>Sets the size (number of descriptors) of the transmit queue for a virtio network interface driver;</summary>
        /// <remarks>
        /// value is a user-provided positive integer tuned for performance.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tx_queue_size Domain#tx_queue_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "txQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TxQueueSize
        {
            get;
            set;
        }
    }
}
