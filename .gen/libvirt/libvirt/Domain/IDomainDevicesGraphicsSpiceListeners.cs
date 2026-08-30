using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceListeners), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceListeners")]
    public interface IDomainDevicesGraphicsSpiceListeners
    {
        /// <summary>Declares a SPICE listener that binds directly to a host IP address using the nested `address` attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSpiceListenersAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares a SPICE listener whose binding is determined by the specified libvirt virtual network and optional address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSpiceListenersNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares a SPICE listener that uses a UNIX domain socket instead of TCP/IP for client connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersSocket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsSpiceListenersSocket? Socket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceListeners), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceListeners")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceListeners
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares a SPICE listener that binds directly to a host IP address using the nested `address` attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSpiceListenersAddress?>();
            }

            /// <summary>Declares a SPICE listener whose binding is determined by the specified libvirt virtual network and optional address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersNetwork\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersNetwork? Network
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSpiceListenersNetwork?>();
            }

            /// <summary>Declares a SPICE listener that uses a UNIX domain socket instead of TCP/IP for client connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersSocket\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersSocket? Socket
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsSpiceListenersSocket?>();
            }
        }
    }
}
