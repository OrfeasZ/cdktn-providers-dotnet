using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceListenersAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceListenersAddress")]
    public interface IDomainDevicesGraphicsSpiceListenersAddress
    {
        /// <summary>Sets the host IP address or hostname on which this SPICE listener should bind (for example `127.0.0.1` or `0.0.0.0`; value is user-provided).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceListenersAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceListenersAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceListenersAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host IP address or hostname on which this SPICE listener should bind (for example `127.0.0.1` or `0.0.0.0`; value is user-provided).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
