using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsi")]
    public class DomainDevicesHostdevsSubsysScsi : libvirt.Domain.IDomainDevicesHostdevsSubsysScsi
    {
        /// <summary>Controls whether raw I/O is allowed for the SCSI hostdev, typically using a yes/no style value as supported by libvirt (for example "yes" or "no").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#raw_io Domain#raw_io}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rawIo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RawIo
        {
            get;
            set;
        }

        private object? _readOnly;

        /// <summary>Marks the SCSI hostdev as read-only when true by emitting the readonly element;</summary>
        /// <remarks>
        /// when false or unset, the device is writable and the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_only Domain#read_only}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get => _readOnly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readOnly = value;
            }
        }

        /// <summary>Sets the SG_IO policy for the SCSI hostdev (e.g. allowing or restricting SG_IO commands), using user-provided values supported by libvirt such as "filtered" or "unfiltered".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sgio Domain#sgio}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sgio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sgio
        {
            get;
            set;
        }

        private object? _shareable;

        /// <summary>Marks the SCSI hostdev as shareable between multiple guests when true by emitting the shareable element;</summary>
        /// <remarks>
        /// when false or unset, the device is treated as exclusively owned and the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shareable Domain#shareable}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Shareable
        {
            get => _shareable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shareable = value;
            }
        }

        /// <summary>Defines the source characteristics of the SCSI host device to passthrough, such as host adapter, SCSI address, or iSCSI parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSource? Source
        {
            get;
            set;
        }
    }
}
