using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceStreaming), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceStreaming")]
    public interface IDomainDevicesGraphicsSpiceStreaming
    {
        /// <summary>Sets the SPICE display streaming mode (for example "filter", "all", or "off", depending on hypervisor support);</summary>
        /// <remarks>
        /// a mode value is required when streaming is configured.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceStreaming), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceStreaming")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SPICE display streaming mode (for example "filter", "all", or "off", depending on hypervisor support);</summary>
            /// <remarks>
            /// a mode value is required when streaming is configured.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
