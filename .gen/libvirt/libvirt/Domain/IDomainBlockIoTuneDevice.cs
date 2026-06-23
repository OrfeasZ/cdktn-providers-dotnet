using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainBlockIoTuneDevice), fullyQualifiedName: "libvirt.domain.DomainBlockIoTuneDevice")]
    public interface IDomainBlockIoTuneDevice
    {
        /// <summary>Sets the absolute path of the host block device whose I/O is being tuned (for example `/dev/vda` or `/dev/sda`);</summary>
        /// <remarks>
        /// this is required for each device entry.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Sets an upper limit, in bytes per second, on read bandwidth for this specific device;</summary>
        /// <remarks>
        /// the value is a positive integer chosen by the user (e.g. <c>10485760</c> for 10 MiB/s).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_bytes_sec Domain#read_bytes_sec}
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

        /// <summary>Sets an upper limit, in I/O operations per second, on reads for this specific device;</summary>
        /// <remarks>
        /// the value is a positive integer chosen by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_iops_sec Domain#read_iops_sec}
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

        /// <summary>Sets the relative I/O weight for this specific device, as an integer in the valid blkio weight range (typically 100–1000), used for proportional scheduling when multiple guests compete.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#weight Domain#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an upper limit, in bytes per second, on write bandwidth for this specific device;</summary>
        /// <remarks>
        /// the value is a positive integer chosen by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#write_bytes_sec Domain#write_bytes_sec}
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

        /// <summary>Sets an upper limit, in I/O operations per second, on writes for this specific device;</summary>
        /// <remarks>
        /// the value is a positive integer chosen by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#write_iops_sec Domain#write_iops_sec}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainBlockIoTuneDevice), fullyQualifiedName: "libvirt.domain.DomainBlockIoTuneDevice")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainBlockIoTuneDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the absolute path of the host block device whose I/O is being tuned (for example `/dev/vda` or `/dev/sda`);</summary>
            /// <remarks>
            /// this is required for each device entry.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets an upper limit, in bytes per second, on read bandwidth for this specific device;</summary>
            /// <remarks>
            /// the value is a positive integer chosen by the user (e.g. <c>10485760</c> for 10 MiB/s).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_bytes_sec Domain#read_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets an upper limit, in I/O operations per second, on reads for this specific device;</summary>
            /// <remarks>
            /// the value is a positive integer chosen by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_iops_sec Domain#read_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadIopsSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the relative I/O weight for this specific device, as an integer in the valid blkio weight range (typically 100–1000), used for proportional scheduling when multiple guests compete.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#weight Domain#weight}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets an upper limit, in bytes per second, on write bandwidth for this specific device;</summary>
            /// <remarks>
            /// the value is a positive integer chosen by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#write_bytes_sec Domain#write_bytes_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeBytesSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteBytesSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets an upper limit, in I/O operations per second, on writes for this specific device;</summary>
            /// <remarks>
            /// the value is a positive integer chosen by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#write_iops_sec Domain#write_iops_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeIopsSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteIopsSec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
