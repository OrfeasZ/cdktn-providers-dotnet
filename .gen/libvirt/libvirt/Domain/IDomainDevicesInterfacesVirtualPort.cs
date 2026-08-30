using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVirtualPort), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPort")]
    public interface IDomainDevicesInterfacesVirtualPort
    {
        /// <summary>Provides backend-specific parameter set for the virtual port profile;</summary>
        /// <remarks>
        /// concrete attributes depend on the underlying virtual switch or network driver.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#params Domain#params}
        /// </remarks>
        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParams\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams? Params
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVirtualPort), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPort")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVirtualPort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Provides backend-specific parameter set for the virtual port profile;</summary>
            /// <remarks>
            /// concrete attributes depend on the underlying virtual switch or network driver.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#params Domain#params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParams\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams? Params
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams?>();
            }
        }
    }
}
