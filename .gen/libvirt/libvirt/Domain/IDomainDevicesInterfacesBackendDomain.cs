using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesBackendDomain), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBackendDomain")]
    public interface IDomainDevicesInterfacesBackendDomain
    {
        /// <summary>Sets the name of the backend (driver) domain that will host the network backend for this interface;</summary>
        /// <remarks>
        /// value must match an existing domain name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain">https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesBackendDomain), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBackendDomain")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesBackendDomain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the backend (driver) domain that will host the network backend for this interface;</summary>
            /// <remarks>
            /// value must match an existing domain name.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain">https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
