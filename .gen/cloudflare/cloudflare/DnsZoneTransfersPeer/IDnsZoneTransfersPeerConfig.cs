using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsZoneTransfersPeer
{
    [JsiiInterface(nativeType: typeof(IDnsZoneTransfersPeerConfig), fullyQualifiedName: "cloudflare.dnsZoneTransfersPeer.DnsZoneTransfersPeerConfig")]
    public interface IDnsZoneTransfersPeerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#account_id DnsZoneTransfersPeer#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The name of the peer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#name DnsZoneTransfersPeer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>IPv4/IPv6 address of primary or secondary nameserver, depending on what zone this peer is linked to.</summary>
        /// <remarks>
        /// For primary zones this IP defines the IP of the secondary nameserver Cloudflare will NOTIFY upon zone changes. For secondary zones this IP defines the IP of the primary nameserver Cloudflare will send AXFR/IXFR requests to.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#ip DnsZoneTransfersPeer#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable IXFR transfer protocol, default is AXFR. Only applicable to secondary zones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#ixfr_enable DnsZoneTransfersPeer#ixfr_enable}
        /// </remarks>
        [JsiiProperty(name: "ixfrEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IxfrEnable
        {
            get
            {
                return null;
            }
        }

        /// <summary>DNS port of primary or secondary nameserver, depending on what zone this peer is linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#port DnsZoneTransfersPeer#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>TSIG authentication will be used for zone transfer if configured.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#tsig_id DnsZoneTransfersPeer#tsig_id}
        /// </remarks>
        [JsiiProperty(name: "tsigId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsigId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsZoneTransfersPeerConfig), fullyQualifiedName: "cloudflare.dnsZoneTransfersPeer.DnsZoneTransfersPeerConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DnsZoneTransfersPeer.IDnsZoneTransfersPeerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#account_id DnsZoneTransfersPeer#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the peer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#name DnsZoneTransfersPeer#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IPv4/IPv6 address of primary or secondary nameserver, depending on what zone this peer is linked to.</summary>
            /// <remarks>
            /// For primary zones this IP defines the IP of the secondary nameserver Cloudflare will NOTIFY upon zone changes. For secondary zones this IP defines the IP of the primary nameserver Cloudflare will send AXFR/IXFR requests to.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#ip DnsZoneTransfersPeer#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable IXFR transfer protocol, default is AXFR. Only applicable to secondary zones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#ixfr_enable DnsZoneTransfersPeer#ixfr_enable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ixfrEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IxfrEnable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>DNS port of primary or secondary nameserver, depending on what zone this peer is linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#port DnsZoneTransfersPeer#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>TSIG authentication will be used for zone transfer if configured.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_zone_transfers_peer#tsig_id DnsZoneTransfersPeer#tsig_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tsigId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsigId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
