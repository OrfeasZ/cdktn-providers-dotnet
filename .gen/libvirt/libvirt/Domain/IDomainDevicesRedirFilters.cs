using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRedirFilters), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirFilters")]
    public interface IDomainDevicesRedirFilters
    {
        /// <summary>Defines a single USB device match rule within the redirection filter, optionally matching by class, vendor, product, and version.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#usb Domain#usb}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesRedirFiltersUsb" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "usb", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFiltersUsb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Usb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRedirFilters), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirFilters")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRedirFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single USB device match rule within the redirection filter, optionally matching by class, vendor, product, and version.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#usb Domain#usb}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesRedirFiltersUsb" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usb", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFiltersUsb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Usb
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
