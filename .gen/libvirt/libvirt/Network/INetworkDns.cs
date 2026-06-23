using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkDns), fullyQualifiedName: "libvirt.network.NetworkDns")]
    public interface INetworkDns
    {
        /// <summary>Controls whether the libvirt-managed DNS service for this network is enabled;</summary>
        /// <remarks>
        /// accepts "yes" or "no". If omitted, libvirt’s default behavior applies.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#enable Network#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more upstream DNS forwarders that this network’s DNS server queries when resolving names.</summary>
        /// <remarks>
        /// Each block configures a single &lt;forwarder&gt; entry.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#forwarders Network#forwarders}
        /// </remarks>
        [JsiiProperty(name: "forwarders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsForwarders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Forwarders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether plain hostnames (without a domain suffix) are forwarded to upstream DNS servers;</summary>
        /// <remarks>
        /// accepts "yes" or "no". If unset, libvirt uses its default for forwarding plain names.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#forward_plain_names Network#forward_plain_names}
        /// </remarks>
        [JsiiProperty(name: "forwardPlainNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardPlainNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a static DNS host entry mapping one IP address to one or more hostnames within this virtual network.</summary>
        /// <remarks>
        /// Multiple host blocks may be used to configure several fixed name-to-address mappings.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#host Network#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures DNS SRV records served by this network’s DNS, describing services available under specific domains.</summary>
        /// <remarks>
        /// Each block represents a single SRV record.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#sr_vs Network#sr_vs}
        /// </remarks>
        [JsiiProperty(name: "srVs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsSrVs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SrVs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures DNS TXT records served by this network’s DNS, allowing arbitrary text data to be associated with names.</summary>
        /// <remarks>
        /// Each block represents a single TXT record.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#tx_ts Network#tx_ts}
        /// </remarks>
        [JsiiProperty(name: "txTs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsTxTs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TxTs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkDns), fullyQualifiedName: "libvirt.network.NetworkDns")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether the libvirt-managed DNS service for this network is enabled;</summary>
            /// <remarks>
            /// accepts "yes" or "no". If omitted, libvirt’s default behavior applies.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#enable Network#enable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines one or more upstream DNS forwarders that this network’s DNS server queries when resolving names.</summary>
            /// <remarks>
            /// Each block configures a single &lt;forwarder&gt; entry.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#forwarders Network#forwarders}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwarders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsForwarders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Forwarders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether plain hostnames (without a domain suffix) are forwarded to upstream DNS servers;</summary>
            /// <remarks>
            /// accepts "yes" or "no". If unset, libvirt uses its default for forwarding plain names.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#forward_plain_names Network#forward_plain_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardPlainNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardPlainNames
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines a static DNS host entry mapping one IP address to one or more hostnames within this virtual network.</summary>
            /// <remarks>
            /// Multiple host blocks may be used to configure several fixed name-to-address mappings.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#host Network#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Host
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures DNS SRV records served by this network’s DNS, describing services available under specific domains.</summary>
            /// <remarks>
            /// Each block represents a single SRV record.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#sr_vs Network#sr_vs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "srVs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsSrVs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SrVs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures DNS TXT records served by this network’s DNS, allowing arbitrary text data to be associated with names.</summary>
            /// <remarks>
            /// Each block represents a single TXT record.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#tx_ts Network#tx_ts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "txTs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsTxTs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TxTs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
