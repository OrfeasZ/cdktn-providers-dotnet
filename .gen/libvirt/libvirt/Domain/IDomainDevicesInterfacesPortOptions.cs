using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesPortOptions), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesPortOptions")]
    public interface IDomainDevicesInterfacesPortOptions
    {
        /// <summary>Controls whether this interface’s traffic is isolated from other guests on the same virtual network;</summary>
        /// <remarks>
        /// boolean-like string where "yes" isolates and "no" (or omission) does not.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other">https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#isolated Domain#isolated}
        /// </remarks>
        [JsiiProperty(name: "isolated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Isolated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesPortOptions), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesPortOptions")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesPortOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether this interface’s traffic is isolated from other guests on the same virtual network;</summary>
            /// <remarks>
            /// boolean-like string where "yes" isolates and "no" (or omission) does not.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other">https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#isolated Domain#isolated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isolated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Isolated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
