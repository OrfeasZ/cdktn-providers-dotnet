using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesRoute), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesRoute")]
    public interface IDomainDevicesInterfacesRoute
    {
        /// <summary>Sets the destination network address for the static route, as an IPv4 or IPv6 address depending on the family (for example, "192.168.10.0" or "2001:db8::").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Sets the gateway IP address used for the static route (must be in the same family as the route address, for example "192.168.10.1").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gateway Domain#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>Specifies the address family for the route, typically "ipv4" or "ipv6";</summary>
        /// <remarks>
        /// if omitted, libvirt infers it from the address format.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#family Domain#family}
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

        /// <summary>Sets an optional numeric route metric (preference) for the static route, as a non-negative integer where lower values are preferred.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metric Domain#metric}
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the netmask for an IPv4 static route as a dotted-quad mask (for example, "255.255.255.0"); use prefix instead for IPv6 or CIDR-style configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#netmask Domain#netmask}
        /// </remarks>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Netmask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the prefix length for the route (for example, 24 for "192.168.10.0/24" or 64 for "2001:db8::/64"), used instead of netmask for CIDR-style configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#prefix Domain#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesRoute), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesRoute")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the destination network address for the static route, as an IPv4 or IPv6 address depending on the family (for example, "192.168.10.0" or "2001:db8::").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the gateway IP address used for the static route (must be in the same family as the route address, for example "192.168.10.1").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gateway Domain#gateway}
            /// </remarks>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the address family for the route, typically "ipv4" or "ipv6";</summary>
            /// <remarks>
            /// if omitted, libvirt infers it from the address format.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#family Domain#family}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Family
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an optional numeric route metric (preference) for the static route, as a non-negative integer where lower values are preferred.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metric Domain#metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Metric
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the netmask for an IPv4 static route as a dotted-quad mask (for example, "255.255.255.0"); use prefix instead for IPv6 or CIDR-style configuration.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#netmask Domain#netmask}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Netmask
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the prefix length for the route (for example, 24 for "192.168.10.0/24" or 64 for "2001:db8::/64"), used instead of netmask for CIDR-style configuration.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#prefix Domain#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Prefix
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
