using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksIoTune), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksIoTune")]
    public interface IDomainDevicesDisksIoTune
    {
        /// <summary>Sets the name of the libvirt disk throttle group that this disk’s I/O limits belong to, allowing multiple disks to share combined throttling;</summary>
        /// <remarks>
        /// the value is user-provided and must match a defined throttle group if used.
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

        /// <summary>Sets the sustained limit, in bytes per second, for read operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer (e.g. 10485760 for 10 MiB/s).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst read bandwidth limit, in bytes per second, that can be used when bursting above the sustained read_bytes_sec rate;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the duration, in seconds, over which the read_bytes_sec_max burst bandwidth may be applied;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the sustained limit, in I/O operations per second, for read operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer (e.g. 1000 for 1000 read IOPS).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst read IOPS limit, in operations per second, that can be used when bursting above the sustained read_iops_sec rate;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the duration, in seconds, over which the read_iops_sec_max burst IOPS may be applied;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the minimum request size, in bytes, that counts as a single I/O when enforcing IOPS limits (smaller requests may be aggregated);</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer (e.g. 4096 for 4 KiB).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the sustained combined limit, in bytes per second, for both read and write operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst combined bandwidth limit, in bytes per second, for both reads and writes when bursting above total_bytes_sec;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the duration, in seconds, over which the total_bytes_sec_max burst combined bandwidth may be applied;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the sustained combined limit, in I/O operations per second, for both read and write operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst combined IOPS limit, in operations per second, for both reads and writes when bursting above total_iops_sec;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the duration, in seconds, over which the total_iops_sec_max burst combined IOPS may be applied;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the sustained limit, in bytes per second, for write operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer (e.g. 5242880 for 5 MiB/s).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst write bandwidth limit, in bytes per second, that can be used when bursting above the sustained write_bytes_sec rate;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the duration, in seconds, over which the write_bytes_sec_max burst bandwidth may be applied;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the sustained limit, in I/O operations per second, for write operations on this disk;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum burst write IOPS limit, in operations per second, that can be used when bursting above the sustained write_iops_sec rate;</summary>
        /// <remarks>
        /// value is a user-provided non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        /// <summary>Sets the maximum length of a temporary burst period for the write IOPS limit, in seconds, used together with write_iops_sec_max to control short-term spikes in disk write operations.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksIoTune), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksIoTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksIoTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the libvirt disk throttle group that this disk’s I/O limits belong to, allowing multiple disks to share combined throttling;</summary>
            /// <remarks>
            /// the value is user-provided and must match a defined throttle group if used.
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

            /// <summary>Sets the sustained limit, in bytes per second, for read operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer (e.g. 10485760 for 10 MiB/s).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec Domain#read_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst read bandwidth limit, in bytes per second, that can be used when bursting above the sustained read_bytes_sec rate;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max Domain#read_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the duration, in seconds, over which the read_bytes_sec_max burst bandwidth may be applied;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_bytes_sec_max_length Domain#read_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained limit, in I/O operations per second, for read operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer (e.g. 1000 for 1000 read IOPS).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec Domain#read_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst read IOPS limit, in operations per second, that can be used when bursting above the sustained read_iops_sec rate;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max Domain#read_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the duration, in seconds, over which the read_iops_sec_max burst IOPS may be applied;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_iops_sec_max_length Domain#read_iops_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the minimum request size, in bytes, that counts as a single I/O when enforcing IOPS limits (smaller requests may be aggregated);</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer (e.g. 4096 for 4 KiB).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_iops_sec Domain#size_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained combined limit, in bytes per second, for both read and write operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec Domain#total_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst combined bandwidth limit, in bytes per second, for both reads and writes when bursting above total_bytes_sec;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max Domain#total_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the duration, in seconds, over which the total_bytes_sec_max burst combined bandwidth may be applied;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_bytes_sec_max_length Domain#total_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained combined limit, in I/O operations per second, for both read and write operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec Domain#total_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst combined IOPS limit, in operations per second, for both reads and writes when bursting above total_iops_sec;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max Domain#total_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the duration, in seconds, over which the total_iops_sec_max burst combined IOPS may be applied;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#total_iops_sec_max_length Domain#total_iops_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalIopsSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained limit, in bytes per second, for write operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer (e.g. 5242880 for 5 MiB/s).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec Domain#write_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst write bandwidth limit, in bytes per second, that can be used when bursting above the sustained write_bytes_sec rate;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max Domain#write_bytes_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the duration, in seconds, over which the write_bytes_sec_max burst bandwidth may be applied;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_bytes_sec_max_length Domain#write_bytes_sec_max_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSecMaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the sustained limit, in I/O operations per second, for write operations on this disk;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec Domain#write_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum burst write IOPS limit, in operations per second, that can be used when bursting above the sustained write_iops_sec rate;</summary>
            /// <remarks>
            /// value is a user-provided non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_iops_sec_max Domain#write_iops_sec_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSecMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSecMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum length of a temporary burst period for the write IOPS limit, in seconds, used together with write_iops_sec_max to control short-term spikes in disk write operations.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
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
