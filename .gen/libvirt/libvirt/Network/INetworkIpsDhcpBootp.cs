using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkIpsDhcpBootp), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpBootp")]
    public interface INetworkIpsDhcpBootp
    {
        /// <summary>Sets the boot file name advertised via BOOTP/PXE (for example "pxelinux.0" or "bootx64.efi").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#file Network#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the IP address of the TFTP/boot server advertised via BOOTP; must be a valid IPv4 or IPv6 address.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#server Network#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Server
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkIpsDhcpBootp), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpBootp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkIpsDhcpBootp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the boot file name advertised via BOOTP/PXE (for example "pxelinux.0" or "bootx64.efi").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#file Network#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? File
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the IP address of the TFTP/boot server advertised via BOOTP; must be a valid IPv4 or IPv6 address.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#server Network#server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Server
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
