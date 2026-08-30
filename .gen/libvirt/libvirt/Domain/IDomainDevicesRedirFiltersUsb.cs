using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRedirFiltersUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirFiltersUsb")]
    public interface IDomainDevicesRedirFiltersUsb
    {
        /// <summary>Sets whether USB devices matching this rule are allowed or blocked by the redirection filter;</summary>
        /// <remarks>
        /// valid values are "yes" or "no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#allow Domain#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"primitive\":\"string\"}")]
        string Allow
        {
            get;
        }

        /// <summary>Sets the USB device class code used to match devices for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric class identifier (for example "0x08" for mass storage).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#class Domain#class}
        /// </remarks>
        [JsiiProperty(name: "class", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Class
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the USB product ID to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric product identifier, typically in hex (for example "0x1234").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#product Domain#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Product
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the USB vendor ID to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric vendor identifier, typically in hex (for example "0x046d").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vendor Domain#vendor}
        /// </remarks>
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vendor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the USB device version (bcdDevice) to match for this filter rule;</summary>
        /// <remarks>
        /// value is a user-provided numeric version identifier (for example "0x0100").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRedirFiltersUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirFiltersUsb")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRedirFiltersUsb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether USB devices matching this rule are allowed or blocked by the redirection filter;</summary>
            /// <remarks>
            /// valid values are "yes" or "no".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#allow Domain#allow}
            /// </remarks>
            [JsiiProperty(name: "allow", typeJson: "{\"primitive\":\"string\"}")]
            public string Allow
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the USB device class code used to match devices for this filter rule;</summary>
            /// <remarks>
            /// value is a user-provided numeric class identifier (for example "0x08" for mass storage).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#class Domain#class}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "class", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Class
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the USB product ID to match for this filter rule;</summary>
            /// <remarks>
            /// value is a user-provided numeric product identifier, typically in hex (for example "0x1234").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#product Domain#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Product
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the USB vendor ID to match for this filter rule;</summary>
            /// <remarks>
            /// value is a user-provided numeric vendor identifier, typically in hex (for example "0x046d").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vendor Domain#vendor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vendor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the USB device version (bcdDevice) to match for this filter rule;</summary>
            /// <remarks>
            /// value is a user-provided numeric version identifier (for example "0x0100").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
