using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesLink), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesLink")]
    public interface IDomainDevicesInterfacesLink
    {
        /// <summary>Sets the virtual link state for the NIC, with valid values "up" or "down" (when "down", the interface behaves as if unplugged in the guest).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#modifying-virtual-link-state">https://libvirt.org/formatdomain.html#modifying-virtual-link-state</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesLink), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesLink")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the virtual link state for the NIC, with valid values "up" or "down" (when "down", the interface behaves as if unplugged in the guest).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#modifying-virtual-link-state">https://libvirt.org/formatdomain.html#modifying-virtual-link-state</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#state Domain#state}
            /// </remarks>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
