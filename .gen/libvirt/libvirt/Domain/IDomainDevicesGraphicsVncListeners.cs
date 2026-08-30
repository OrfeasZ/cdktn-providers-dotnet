using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsVncListeners), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVncListeners")]
    public interface IDomainDevicesGraphicsVncListeners
    {
        /// <summary>Declares a SPICE listener that binds directly to a host IP address using the nested `address` attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress? Address
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
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork? Network
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
        [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersSocket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket? Socket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsVncListeners), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVncListeners")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsVncListeners
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares a SPICE listener that binds directly to a host IP address using the nested `address` attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress?>();
            }

            /// <summary>Declares a SPICE listener whose binding is determined by the specified libvirt virtual network and optional address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersNetwork\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork? Network
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork?>();
            }

            /// <summary>Declares a SPICE listener that uses a UNIX domain socket instead of TCP/IP for client connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersSocket\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket? Socket
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket?>();
            }
        }
    }
}
