using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkRoutes), fullyQualifiedName: "libvirt.network.NetworkRoutes")]
    public interface INetworkRoutes
    {
        /// <summary>Sets the destination network address (in IPv4 or IPv6 form) for this static route;</summary>
        /// <remarks>
        /// value is user-provided and should match the route’s prefix (e.g. "192.168.2.0/24" or "2001:db8::/64").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#address Network#address}
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

        /// <summary>Specifies the address family for this static route; valid values are "ipv4" or "ipv6".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#family Network#family}
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

        /// <summary>Sets the next-hop gateway IP address for this static route, pointing to a guest-accessible router;</summary>
        /// <remarks>
        /// value is user-provided and must be in the family specified by family.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#gateway Network#gateway}
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

        /// <summary>Sets the routing metric for this static route;</summary>
        /// <remarks>
        /// lower values have higher priority, and the value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#metric Network#metric}
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the IPv4 netmask for the destination of this static route as a dotted-quad string (for example, "255.255.255.0"); use this instead of prefix for netmask-based routes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#netmask Network#netmask}
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

        /// <summary>Sets the CIDR prefix length for the destination of this static route as a user-provided integer between 0 and 128 (depending on IPv4/IPv6);</summary>
        /// <remarks>
        /// use this instead of netmask for prefix-based routes.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#prefix Network#prefix}
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

        [JsiiTypeProxy(nativeType: typeof(INetworkRoutes), fullyQualifiedName: "libvirt.network.NetworkRoutes")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkRoutes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the destination network address (in IPv4 or IPv6 form) for this static route;</summary>
            /// <remarks>
            /// value is user-provided and should match the route’s prefix (e.g. "192.168.2.0/24" or "2001:db8::/64").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#address Network#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the address family for this static route; valid values are "ipv4" or "ipv6".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#family Network#family}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Family
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the next-hop gateway IP address for this static route, pointing to a guest-accessible router;</summary>
            /// <remarks>
            /// value is user-provided and must be in the family specified by family.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#gateway Network#gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gateway
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the routing metric for this static route;</summary>
            /// <remarks>
            /// lower values have higher priority, and the value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#metric Network#metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metric
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the IPv4 netmask for the destination of this static route as a dotted-quad string (for example, "255.255.255.0"); use this instead of prefix for netmask-based routes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#netmask Network#netmask}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Netmask
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the CIDR prefix length for the destination of this static route as a user-provided integer between 0 and 128 (depending on IPv4/IPv6);</summary>
            /// <remarks>
            /// use this instead of netmask for prefix-based routes.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#static-routes">https://libvirt.org/formatnetwork.html#static-routes</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#prefix Network#prefix}
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
