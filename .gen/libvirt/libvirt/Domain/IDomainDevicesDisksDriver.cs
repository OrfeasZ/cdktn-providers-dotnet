using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriver")]
    public interface IDomainDevicesDisksDriver
    {
        /// <summary>Configures whether the virtio disk uses Address Translation Service (ATS) on the virtio transport; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ats
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the host-side cache mode for the disk I/O, using libvirt/QEMU cache policies such as "none", "writeback", or "writethrough";</summary>
        /// <remarks>
        /// the exact string is user-provided but must be a valid cache mode for the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls the disk copy-on-read behavior (e.g. forcing data into cache when read) using a yes/no style value such as "on"/"off"; the exact string is user-provided but must be supported by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#copy_on_read Domain#copy_on_read}
        /// </remarks>
        [JsiiProperty(name: "copyOnRead", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CopyOnRead
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets how the disk driver handles writes of zero blocks (e.g. "on", "off", or "unmap") to allow optimization or discard; the string must be one of the modes supported by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#detect_zeros Domain#detect_zeros}
        /// </remarks>
        [JsiiProperty(name: "detectZeros", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DetectZeros
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether and how discard/TRIM requests are passed from the guest to the backing storage (for example "unmap" or "ignore");</summary>
        /// <remarks>
        /// the value must be a discard mode supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard Domain#discard}
        /// </remarks>
        [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Discard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether discard operations avoid the QEMU "unref" optimization, using a driver-specific yes/no style flag;</summary>
        /// <remarks>
        /// the exact value is user-provided but must be supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard_no_unref Domain#discard_no_unref}
        /// </remarks>
        [JsiiProperty(name: "discardNoUnref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiscardNoUnref
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the action taken by the hypervisor on I/O errors for this disk (for example "stop", "ignore", "enospace", or "report");</summary>
        /// <remarks>
        /// the string must be one of the error policies supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#error_policy Domain#error_policy}
        /// </remarks>
        [JsiiProperty(name: "errorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables the virtio "event_idx" optimization for the disk, using a yes/no style value such as "on"/"off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#event_idx Domain#event_idx}
        /// </remarks>
        [JsiiProperty(name: "eventIdx", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventIdx
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the I/O mode for accessing the disk (for example "threads" or "native");</summary>
        /// <remarks>
        /// the value is user-provided but must match a valid I/O mode supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io Domain#io}
        /// </remarks>
        [JsiiProperty(name: "io", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Io
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether ioeventfd is used for this disk device to optimize I/O notification, using a yes/no style value such as "on"/"off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_event_fd Domain#io_event_fd}
        /// </remarks>
        [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IoEventFd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables use of an emulated IOMMU for this disk device on the virtio transport, using "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iommu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns the disk to a specific IOThread by numeric id, matching an IOThread defined in the domain;</summary>
        /// <remarks>
        /// the value is user-provided and must reference an existing IOThread.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread Domain#io_thread}
        /// </remarks>
        [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IoThread
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines per-disk IOThread mapping information, allowing this disk to use one or more dedicated IOThreads instead of the default I/O path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiProperty(name: "ioThreads", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreads\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksDriverIoThreads? IoThreads
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures metadata cache behavior for the mirrored backing store’s data store format (for example, limiting the size of cached metadata).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#metadata_cache Domain#metadata_cache}
        /// </remarks>
        [JsiiProperty(name: "metadataCache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverMetadataCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksDriverMetadataCache? MetadataCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the underlying disk driver implementation name, typically a string such as "qemu" to control which backend handles the disk.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the virtio-blk device uses packed virtqueue layout; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Packed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the virtio device uses a separate page per virtqueue for virtqueue descriptors; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PagePerVq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of virtio I/O queues for this disk, as a positive integer, to enable multiqueue operation.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Queues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the virtqueue size (number of entries) for this disk’s virtio queue as a positive integer, if supported by the driver.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queue_size Domain#queue_size}
        /// </remarks>
        [JsiiProperty(name: "queueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the policy for handling read errors on the disk, typically one of "ignore", "stop", or driver-specific values.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rerror_policy Domain#rerror_policy}
        /// </remarks>
        [JsiiProperty(name: "rerrorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RerrorPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#statistics Domain#statistics}.</summary>
        [JsiiProperty(name: "statistics", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatistics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksDriverStatistics? Statistics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the on-disk image format for the disk driver, such as "raw", "qcow2", or other user-provided format strings supported by qemu.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriver")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures whether the virtio disk uses Address Translation Service (ATS) on the virtio transport; accepts "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ats
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the host-side cache mode for the disk I/O, using libvirt/QEMU cache policies such as "none", "writeback", or "writethrough";</summary>
            /// <remarks>
            /// the exact string is user-provided but must be a valid cache mode for the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cache
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls the disk copy-on-read behavior (e.g. forcing data into cache when read) using a yes/no style value such as "on"/"off"; the exact string is user-provided but must be supported by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#copy_on_read Domain#copy_on_read}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copyOnRead", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CopyOnRead
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets how the disk driver handles writes of zero blocks (e.g. "on", "off", or "unmap") to allow optimization or discard; the string must be one of the modes supported by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#detect_zeros Domain#detect_zeros}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "detectZeros", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DetectZeros
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures whether and how discard/TRIM requests are passed from the guest to the backing storage (for example "unmap" or "ignore");</summary>
            /// <remarks>
            /// the value must be a discard mode supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard Domain#discard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Discard
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether discard operations avoid the QEMU "unref" optimization, using a driver-specific yes/no style flag;</summary>
            /// <remarks>
            /// the exact value is user-provided but must be supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard_no_unref Domain#discard_no_unref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discardNoUnref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiscardNoUnref
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the action taken by the hypervisor on I/O errors for this disk (for example "stop", "ignore", "enospace", or "report");</summary>
            /// <remarks>
            /// the string must be one of the error policies supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#error_policy Domain#error_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables the virtio "event_idx" optimization for the disk, using a yes/no style value such as "on"/"off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#event_idx Domain#event_idx}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventIdx", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventIdx
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the I/O mode for accessing the disk (for example "threads" or "native");</summary>
            /// <remarks>
            /// the value is user-provided but must match a valid I/O mode supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io Domain#io}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "io", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Io
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether ioeventfd is used for this disk device to optimize I/O notification, using a yes/no style value such as "on"/"off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_event_fd Domain#io_event_fd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IoEventFd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables use of an emulated IOMMU for this disk device on the virtio transport, using "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Iommu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Assigns the disk to a specific IOThread by numeric id, matching an IOThread defined in the domain;</summary>
            /// <remarks>
            /// the value is user-provided and must reference an existing IOThread.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread Domain#io_thread}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IoThread
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Defines per-disk IOThread mapping information, allowing this disk to use one or more dedicated IOThreads instead of the default I/O path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreads", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreads\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksDriverIoThreads? IoThreads
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksDriverIoThreads?>();
            }

            /// <summary>Configures metadata cache behavior for the mirrored backing store’s data store format (for example, limiting the size of cached metadata).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#metadata_cache Domain#metadata_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataCache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverMetadataCache\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksDriverMetadataCache? MetadataCache
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksDriverMetadataCache?>();
            }

            /// <summary>Sets the underlying disk driver implementation name, typically a string such as "qemu" to control which backend handles the disk.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the virtio-blk device uses packed virtqueue layout; accepts "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Packed
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the virtio device uses a separate page per virtqueue for virtqueue descriptors; accepts "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PagePerVq
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the number of virtio I/O queues for this disk, as a positive integer, to enable multiqueue operation.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Queues
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the virtqueue size (number of entries) for this disk’s virtio queue as a positive integer, if supported by the driver.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queue_size Domain#queue_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the policy for handling read errors on the disk, typically one of "ignore", "stop", or driver-specific values.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rerror_policy Domain#rerror_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rerrorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RerrorPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#statistics Domain#statistics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "statistics", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatistics\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksDriverStatistics? Statistics
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksDriverStatistics?>();
            }

            /// <summary>Sets the on-disk image format for the disk driver, such as "raw", "qcow2", or other user-provided format strings supported by qemu.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
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
