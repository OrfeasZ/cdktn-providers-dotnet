using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRedirFiltersUsb")]
    public class DomainDevicesRedirFiltersUsb : libvirt.Domain.IDomainDevicesRedirFiltersUsb
    {
        /// <summary>Sets whether USB devices matching this rule are allowed or blocked by the redirection filter;</summary>
        /// <remarks>
        /// valid values are "yes" or "no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#allow Domain#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"primitive\":\"string\"}")]
        public string Allow
        {
            get;
            set;
        }

        /// <summary>Sets the USB device class code used to match devices for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric class identifier (for example "0x08" for mass storage).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#class Domain#class}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "class", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Class
        {
            get;
            set;
        }

        /// <summary>Sets the USB product ID to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric product identifier, typically in hex (for example "0x1234").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#product Domain#product}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Product
        {
            get;
            set;
        }

        /// <summary>Sets the USB vendor ID to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric vendor identifier, typically in hex (for example "0x046d").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vendor
        {
            get;
            set;
        }

        /// <summary>Sets the USB device version (bcdDevice) to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric version identifier (for example "0x0100").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#version Domain#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
