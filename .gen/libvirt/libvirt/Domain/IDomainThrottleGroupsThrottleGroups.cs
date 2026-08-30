using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainThrottleGroupsThrottleGroups), fullyQualifiedName: "libvirt.domain.DomainThrottleGroupsThrottleGroups")]
    public interface IDomainThrottleGroupsThrottleGroups
    {
        /// <summary>Sets the unique name of this throttle group, which must match the `group_name` used by disk `throttlefilters` to attach a disk to the group;</summary>
        /// <remarks>
        /// the name string is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#group_name Domain#group_name}
        /// </remarks>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the sustained read bandwidth limit for the group in bytes per second;</summary>
        /// <remarks>
        /// value is a non-negative integer, for example <c>10485760</c> for 10 MiB/s.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec Domain#read_bytes_sec}
        /// </remarks>
        [JsiiProperty(name: "readBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadBytesSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst read bandwidth limit for the group in bytes per second;</summary>
        /// <remarks>
        /// value is a non-negative integer and is used together with <c>read_bytes_sec_max_length</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max Domain#read_bytes_sec_max}
        /// </remarks>
        [JsiiProperty(name: "readBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadBytesSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the time window in seconds over which the `read_bytes_sec_max` burst limit applies;</summary>
        /// <remarks>
        /// value is a non-negative integer number of seconds.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max_length Domain#read_bytes_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "readBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadBytesSecMaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the sustained read IOPS limit for the group;</summary>
        /// <remarks>
        /// value is a non-negative integer specifying maximum read operations per second.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec Domain#read_iops_sec}
        /// </remarks>
        [JsiiProperty(name: "readIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadIopsSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst read IOPS limit for the group;</summary>
        /// <remarks>
        /// value is a non-negative integer and is used together with <c>read_iops_sec_max_length</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max Domain#read_iops_sec_max}
        /// </remarks>
        [JsiiProperty(name: "readIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadIopsSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the time window in seconds over which the `read_iops_sec_max` burst IOPS limit applies;</summary>
        /// <remarks>
        /// value is a non-negative integer number of seconds.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max_length Domain#read_iops_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "readIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadIopsSecMaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the I/O size in bytes used when converting between size-based and operation-based limits for this group;</summary>
        /// <remarks>
        /// value is a positive integer, typically a block size such as <c>4096</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_iops_sec Domain#size_iops_sec}
        /// </remarks>
        [JsiiProperty(name: "sizeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeIopsSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the sustained aggregate bandwidth limit (read + write) for the group in bytes per second;</summary>
        /// <remarks>
        /// value is a non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec Domain#total_bytes_sec}
        /// </remarks>
        [JsiiProperty(name: "totalBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalBytesSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst aggregate bandwidth limit (read + write) for the group in bytes per second;</summary>
        /// <remarks>
        /// value is a non-negative integer and is typically paired with a corresponding <c>*_max_length</c> window.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max Domain#total_bytes_sec_max}
        /// </remarks>
        [JsiiProperty(name: "totalBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalBytesSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the I/O burst length, in bytes, over which the total_bytes_sec_max limit is measured for the throttle group;</summary>
        /// <remarks>
        /// the value is user-provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max_length Domain#total_bytes_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "totalBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalBytesSecMaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the steady‑state limit on the total number of I/O operations per second (reads + writes) allowed for disks in this throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer (IOPS).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec Domain#total_iops_sec}
        /// </remarks>
        [JsiiProperty(name: "totalIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalIopsSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst IOPS limit (reads + writes) for the throttle group, above the steady total_iops_sec value;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max Domain#total_iops_sec_max}
        /// </remarks>
        [JsiiProperty(name: "totalIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalIopsSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the I/O burst length, in number of requests, over which the total_iops_sec_max limit is measured for the throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max_length Domain#total_iops_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "totalIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalIopsSecMaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the steady‑state limit on write throughput in bytes per second for disks in this throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer (e.g. 104857600 for 100 MiB/s).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec Domain#write_bytes_sec}
        /// </remarks>
        [JsiiProperty(name: "writeBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteBytesSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst write throughput in bytes per second for the throttle group, above the steady write_bytes_sec limit;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max Domain#write_bytes_sec_max}
        /// </remarks>
        [JsiiProperty(name: "writeBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteBytesSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the I/O burst length, in bytes, over which the write_bytes_sec_max limit is measured for the throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max_length Domain#write_bytes_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "writeBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteBytesSecMaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the steady‑state limit on write IOPS for disks in this throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer (number of write requests per second).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec Domain#write_iops_sec}
        /// </remarks>
        [JsiiProperty(name: "writeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteIopsSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum burst write IOPS limit for the throttle group, above the steady write_iops_sec value;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec_max Domain#write_iops_sec_max}
        /// </remarks>
        [JsiiProperty(name: "writeIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteIopsSecMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the I/O burst length, in number of write requests, over which the write_iops_sec_max limit is measured for the throttle group;</summary>
        /// <remarks>
        /// the value is user‑provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec_max_length Domain#write_iops_sec_max_length}
        /// </remarks>
        [JsiiProperty(name: "writeIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteIopsSecMaxLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainThrottleGroupsThrottleGroups), fullyQualifiedName: "libvirt.domain.DomainThrottleGroupsThrottleGroups")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainThrottleGroupsThrottleGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the unique name of this throttle group, which must match the `group_name` used by disk `throttlefilters` to attach a disk to the group;</summary>
            /// <remarks>
            /// the name string is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#group_name Domain#group_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the sustained read bandwidth limit for the group in bytes per second;</summary>
            /// <remarks>
            /// value is a non-negative integer, for example <c>10485760</c> for 10 MiB/s.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec Domain#read_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst read bandwidth limit for the group in bytes per second;</summary>
            /// <remarks>
            /// value is a non-negative integer and is used together with <c>read_bytes_sec_max_length</c>.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max Domain#read_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the time window in seconds over which the `read_bytes_sec_max` burst limit applies;</summary>
            /// <remarks>
            /// value is a non-negative integer number of seconds.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max_length Domain#read_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained read IOPS limit for the group;</summary>
            /// <remarks>
            /// value is a non-negative integer specifying maximum read operations per second.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec Domain#read_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst read IOPS limit for the group;</summary>
            /// <remarks>
            /// value is a non-negative integer and is used together with <c>read_iops_sec_max_length</c>.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max Domain#read_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the time window in seconds over which the `read_iops_sec_max` burst IOPS limit applies;</summary>
            /// <remarks>
            /// value is a non-negative integer number of seconds.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max_length Domain#read_iops_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the I/O size in bytes used when converting between size-based and operation-based limits for this group;</summary>
            /// <remarks>
            /// value is a positive integer, typically a block size such as <c>4096</c>.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_iops_sec Domain#size_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained aggregate bandwidth limit (read + write) for the group in bytes per second;</summary>
            /// <remarks>
            /// value is a non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec Domain#total_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst aggregate bandwidth limit (read + write) for the group in bytes per second;</summary>
            /// <remarks>
            /// value is a non-negative integer and is typically paired with a corresponding <c>*_max_length</c> window.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max Domain#total_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the I/O burst length, in bytes, over which the total_bytes_sec_max limit is measured for the throttle group;</summary>
            /// <remarks>
            /// the value is user-provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max_length Domain#total_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the steady‑state limit on the total number of I/O operations per second (reads + writes) allowed for disks in this throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer (IOPS).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec Domain#total_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst IOPS limit (reads + writes) for the throttle group, above the steady total_iops_sec value;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max Domain#total_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the I/O burst length, in number of requests, over which the total_iops_sec_max limit is measured for the throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max_length Domain#total_iops_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the steady‑state limit on write throughput in bytes per second for disks in this throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer (e.g. 104857600 for 100 MiB/s).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec Domain#write_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst write throughput in bytes per second for the throttle group, above the steady write_bytes_sec limit;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max Domain#write_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the I/O burst length, in bytes, over which the write_bytes_sec_max limit is measured for the throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max_length Domain#write_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the steady‑state limit on write IOPS for disks in this throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer (number of write requests per second).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec Domain#write_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst write IOPS limit for the throttle group, above the steady write_iops_sec value;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec_max Domain#write_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the I/O burst length, in number of write requests, over which the write_iops_sec_max limit is measured for the throttle group;</summary>
            /// <remarks>
            /// the value is user‑provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec_max_length Domain#write_iops_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
