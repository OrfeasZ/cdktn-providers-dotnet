using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceSlices")]
    public class DomainDevicesDisksSourceSlices : libvirt.Domain.IDomainDevicesDisksSourceSlices
    {
        private object? _slices;

        /// <summary>Configures one or more slices of the backing-store source, each describing a contiguous portion of the underlying device or file that is exposed through this mirror backing store.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slices Domain#slices}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlicesSlices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Slices
        {
            get => _slices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slices = value;
            }
        }
    }
}
