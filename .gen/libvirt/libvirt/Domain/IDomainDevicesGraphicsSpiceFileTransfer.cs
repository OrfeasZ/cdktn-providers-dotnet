using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceFileTransfer), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceFileTransfer")]
    public interface IDomainDevicesGraphicsSpiceFileTransfer
    {
        /// <summary>Controls whether SPICE client file transfer into the guest is enabled; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}")]
        string Enable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceFileTransfer), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceFileTransfer")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceFileTransfer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether SPICE client file transfer into the guest is enabled; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
            /// </remarks>
            [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}")]
            public string Enable
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
