using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSourceReservations")]
    public class DomainOsNvRamSourceReservations : libvirt.Domain.IDomainOsNvRamSourceReservations
    {
        /// <summary>Controls whether persistent reservations are enabled for the mirrored disk’s backing-store source;</summary>
        /// <remarks>
        /// value is user-provided and typically expects "yes" or "no" semantics per libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Enabled
        {
            get;
            set;
        }

        private object? _managed;

        /// <summary>Indicates whether reservations are managed by libvirt ("yes") or externally ("no");</summary>
        /// <remarks>
        /// value is provided as a string and translated to a boolean, with "yes" meaning true and "no" meaning false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Managed
        {
            get => _managed;
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
                _managed = value;
            }
        }

        /// <summary>Selects the mechanism used to provide reservation control for the mirrored backing-store source, such as a D-Bus service or a device/file endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceReservationsSource? Source
        {
            get;
            set;
        }
    }
}
