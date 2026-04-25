using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsFirewall
{
    [JsiiInterface(nativeType: typeof(IDnsFirewallConfig), fullyQualifiedName: "cloudflare.dnsFirewall.DnsFirewallConfig")]
    public interface IDnsFirewallConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>DNS Firewall cluster name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#name DnsFirewall#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#upstream_ips DnsFirewall#upstream_ips}.</summary>
        [JsiiProperty(name: "upstreamIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] UpstreamIps
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#account_id DnsFirewall#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Attack mitigation settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#attack_mitigation DnsFirewall#attack_mitigation}
        /// </remarks>
        [JsiiProperty(name: "attackMitigation", typeJson: "{\"fqn\":\"cloudflare.dnsFirewall.DnsFirewallAttackMitigation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DnsFirewall.IDnsFirewallAttackMitigation? AttackMitigation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to refuse to answer queries for the ANY type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#deprecate_any_requests DnsFirewall#deprecate_any_requests}
        /// </remarks>
        [JsiiProperty(name: "deprecateAnyRequests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeprecateAnyRequests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to forward client IP (resolver) subnet if no EDNS Client Subnet is sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#ecs_fallback DnsFirewall#ecs_fallback}
        /// </remarks>
        [JsiiProperty(name: "ecsFallback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcsFallback
        {
            get
            {
                return null;
            }
        }

        /// <summary>By default, Cloudflare attempts to cache responses for as long as indicated by the TTL received from upstream nameservers.</summary>
        /// <remarks>
        /// This setting
        /// sets an upper bound on this duration. For caching purposes, higher TTLs
        /// will be decreased to the maximum value defined by this setting.
        ///
        /// This setting does not affect the TTL value in the DNS response
        /// Cloudflare returns to clients. Cloudflare will always forward the TTL
        /// value received from upstream nameservers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#maximum_cache_ttl DnsFirewall#maximum_cache_ttl}
        /// </remarks>
        [JsiiProperty(name: "maximumCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumCacheTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>By default, Cloudflare attempts to cache responses for as long as indicated by the TTL received from upstream nameservers.</summary>
        /// <remarks>
        /// This setting
        /// sets a lower bound on this duration. For caching purposes, lower TTLs
        /// will be increased to the minimum value defined by this setting.
        ///
        /// This setting does not affect the TTL value in the DNS response
        /// Cloudflare returns to clients. Cloudflare will always forward the TTL
        /// value received from upstream nameservers.
        ///
        /// Note that, even with this setting, there is no guarantee that a
        /// response will be cached for at least the specified duration. Cached
        /// responses may be removed earlier for capacity or other operational
        /// reasons.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#minimum_cache_ttl DnsFirewall#minimum_cache_ttl}
        /// </remarks>
        [JsiiProperty(name: "minimumCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumCacheTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>This setting controls how long DNS Firewall should cache negative responses (e.g., NXDOMAIN) from the upstream servers.</summary>
        /// <remarks>
        /// This setting does not affect the TTL value in the DNS response
        /// Cloudflare returns to clients. Cloudflare will always forward the TTL
        /// value received from upstream nameservers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#negative_cache_ttl DnsFirewall#negative_cache_ttl}
        /// </remarks>
        [JsiiProperty(name: "negativeCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NegativeCacheTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ratelimit in queries per second per datacenter (applies to DNS queries sent to the upstream nameservers configured on the cluster).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#ratelimit DnsFirewall#ratelimit}
        /// </remarks>
        [JsiiProperty(name: "ratelimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ratelimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of retries for fetching DNS responses from upstream nameservers (not counting the initial attempt).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#retries DnsFirewall#retries}
        /// </remarks>
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Retries
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsFirewallConfig), fullyQualifiedName: "cloudflare.dnsFirewall.DnsFirewallConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DnsFirewall.IDnsFirewallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DNS Firewall cluster name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#name DnsFirewall#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#upstream_ips DnsFirewall#upstream_ips}.</summary>
            [JsiiProperty(name: "upstreamIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] UpstreamIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#account_id DnsFirewall#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Attack mitigation settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#attack_mitigation DnsFirewall#attack_mitigation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attackMitigation", typeJson: "{\"fqn\":\"cloudflare.dnsFirewall.DnsFirewallAttackMitigation\"}", isOptional: true)]
            public cloudflare.DnsFirewall.IDnsFirewallAttackMitigation? AttackMitigation
            {
                get => GetInstanceProperty<cloudflare.DnsFirewall.IDnsFirewallAttackMitigation?>();
            }

            /// <summary>Whether to refuse to answer queries for the ANY type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#deprecate_any_requests DnsFirewall#deprecate_any_requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecateAnyRequests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeprecateAnyRequests
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to forward client IP (resolver) subnet if no EDNS Client Subnet is sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#ecs_fallback DnsFirewall#ecs_fallback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsFallback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EcsFallback
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>By default, Cloudflare attempts to cache responses for as long as indicated by the TTL received from upstream nameservers.</summary>
            /// <remarks>
            /// This setting
            /// sets an upper bound on this duration. For caching purposes, higher TTLs
            /// will be decreased to the maximum value defined by this setting.
            ///
            /// This setting does not affect the TTL value in the DNS response
            /// Cloudflare returns to clients. Cloudflare will always forward the TTL
            /// value received from upstream nameservers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#maximum_cache_ttl DnsFirewall#maximum_cache_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumCacheTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>By default, Cloudflare attempts to cache responses for as long as indicated by the TTL received from upstream nameservers.</summary>
            /// <remarks>
            /// This setting
            /// sets a lower bound on this duration. For caching purposes, lower TTLs
            /// will be increased to the minimum value defined by this setting.
            ///
            /// This setting does not affect the TTL value in the DNS response
            /// Cloudflare returns to clients. Cloudflare will always forward the TTL
            /// value received from upstream nameservers.
            ///
            /// Note that, even with this setting, there is no guarantee that a
            /// response will be cached for at least the specified duration. Cached
            /// responses may be removed earlier for capacity or other operational
            /// reasons.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#minimum_cache_ttl DnsFirewall#minimum_cache_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumCacheTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>This setting controls how long DNS Firewall should cache negative responses (e.g., NXDOMAIN) from the upstream servers.</summary>
            /// <remarks>
            /// This setting does not affect the TTL value in the DNS response
            /// Cloudflare returns to clients. Cloudflare will always forward the TTL
            /// value received from upstream nameservers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#negative_cache_ttl DnsFirewall#negative_cache_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "negativeCacheTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NegativeCacheTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Ratelimit in queries per second per datacenter (applies to DNS queries sent to the upstream nameservers configured on the cluster).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#ratelimit DnsFirewall#ratelimit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ratelimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ratelimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of retries for fetching DNS responses from upstream nameservers (not counting the initial attempt).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#retries DnsFirewall#retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Retries
            {
                get => GetInstanceProperty<double?>();
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
