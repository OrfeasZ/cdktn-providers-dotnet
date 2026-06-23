using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRedirFilters")]
    public class DomainDevicesRedirFilters : libvirt.Domain.IDomainDevicesRedirFilters
    {
        private object? _usb;

        /// <summary>Defines a single USB device match rule within the redirection filter, optionally matching by class, vendor, product, and version.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#usb Domain#usb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usb", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFiltersUsb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Usb
        {
            get => _usb;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesRedirFiltersUsb[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRedirFiltersUsb).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _usb = value;
            }
        }
    }
}
