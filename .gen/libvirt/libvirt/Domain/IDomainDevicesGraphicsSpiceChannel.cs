using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceChannel), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceChannel")]
    public interface IDomainDevicesGraphicsSpiceChannel
    {
        /// <summary>Sets how the SPICE channel connects, typically "secure" or "insecure" depending on the desired transport;</summary>
        /// <remarks>
        /// the value is required and user-provided.
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

        /// <summary>Names the SPICE channel to configure (for example, "main", "cursor", "display", "record", "playback");</summary>
        /// <remarks>
        /// this value is required and must match a supported SPICE channel name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceChannel), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceChannel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceChannel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets how the SPICE channel connects, typically "secure" or "insecure" depending on the desired transport;</summary>
            /// <remarks>
            /// the value is required and user-provided.
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

            /// <summary>Names the SPICE channel to configure (for example, "main", "cursor", "display", "record", "playback");</summary>
            /// <remarks>
            /// this value is required and must match a supported SPICE channel name.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
