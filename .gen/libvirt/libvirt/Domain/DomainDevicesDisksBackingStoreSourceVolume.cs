using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVolume")]
    public class DomainDevicesDisksBackingStoreSourceVolume : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVolume
    {
        /// <summary>Sets the access mode with which the storage volume is used as the backingStore source (for example, "readOnly" or "readWrite" depending on driver support);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Names the storage pool that contains the backing storage volume used as the mirror backingStore source;</summary>
        /// <remarks>
        /// must match an existing libvirt storage pool name.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pool Domain#pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pool
        {
            get;
            set;
        }

        private object? _secLabel;

        /// <summary>Configures an optional security label override applied to the backing storage volume used as the mirror backingStore source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceVolumeSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecLabel
        {
            get => _secLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVolumeSecLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVolumeSecLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secLabel = value;
            }
        }

        /// <summary>Sets the name of the storage volume within the specified pool that is used as the backingStore source for the mirrored disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Volume
        {
            get;
            set;
        }
    }
}
