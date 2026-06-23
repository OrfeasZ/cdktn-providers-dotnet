using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsMidoNet), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet")]
    public interface IDomainDevicesInterfacesVirtualPortParamsMidoNet
    {
        /// <summary>Sets the Midonet virtual interface identifier associated with this NIC;</summary>
        /// <remarks>
        /// the value is user-provided and must match the interface ID configured in Midonet.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface_id Domain#interface_id}
        /// </remarks>
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsMidoNet), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsMidoNet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the Midonet virtual interface identifier associated with this NIC;</summary>
            /// <remarks>
            /// the value is user-provided and must match the interface ID configured in Midonet.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface_id Domain#interface_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
