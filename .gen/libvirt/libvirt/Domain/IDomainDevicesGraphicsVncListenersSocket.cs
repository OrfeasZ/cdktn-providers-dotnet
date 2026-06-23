using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsVncListenersSocket), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVncListenersSocket")]
    public interface IDomainDevicesGraphicsVncListenersSocket
    {
        /// <summary>Sets the filesystem path to the UNIX domain socket used by this SPICE listener (for example `/var/run/libvirt/qemu/spice.sock`; value is user-provided).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Socket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsVncListenersSocket), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVncListenersSocket")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the filesystem path to the UNIX domain socket used by this SPICE listener (for example `/var/run/libvirt/qemu/spice.sock`; value is user-provided).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#socket Domain#socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Socket
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
