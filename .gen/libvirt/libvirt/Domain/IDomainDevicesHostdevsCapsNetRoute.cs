using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsNetRoute), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNetRoute")]
    public interface IDomainDevicesHostdevsCapsNetRoute
    {
        /// <summary>Sets the destination network address for the static route associated with the passthrough host device;</summary>
        /// <remarks>
        /// value is user-provided (for example, "10.0.0.0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the address family for the static route, typically "ipv4" or "ipv6".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#family Domain#family}
        /// </remarks>
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Family
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the gateway IP address used to reach the route destination network via the passthrough device; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gateway Domain#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gateway
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsNetRoute), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNetRoute")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsNetRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the destination network address for the static route associated with the passthrough host device;</summary>
            /// <remarks>
            /// value is user-provided (for example, "10.0.0.0").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the address family for the static route, typically "ipv4" or "ipv6".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#family Domain#family}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Family
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the gateway IP address used to reach the route destination network via the passthrough device; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gateway Domain#gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gateway
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
