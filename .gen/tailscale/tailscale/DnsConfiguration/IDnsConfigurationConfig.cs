using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsConfiguration
{
    [JsiiInterface(nativeType: typeof(IDnsConfigurationConfig), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationConfig")]
    public interface IDnsConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Whether or not to enable MagicDNS. Defaults to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#magic_dns DnsConfiguration#magic_dns}
        /// </remarks>
        [JsiiProperty(name: "magicDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MagicDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>nameservers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#nameservers DnsConfiguration#nameservers}
        /// </remarks>
        [JsiiProperty(name: "nameservers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationNameservers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nameservers
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, use the configured DNS servers in `nameservers` to resolve names outside the tailnet.</summary>
        /// <remarks>
        /// When disabled, devices will prefer their local DNS configuration. Defaults to false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#override_local_dns DnsConfiguration#override_local_dns}
        /// </remarks>
        [JsiiProperty(name: "overrideLocalDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverrideLocalDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional search domains. When MagicDNS is on, the tailnet domain is automatically included as the first search domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#search_paths DnsConfiguration#search_paths}
        /// </remarks>
        [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SearchPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>split_dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#split_dns DnsConfiguration#split_dns}
        /// </remarks>
        [JsiiProperty(name: "splitDns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationSplitDns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SplitDns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsConfigurationConfig), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.DnsConfiguration.IDnsConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether or not to enable MagicDNS. Defaults to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#magic_dns DnsConfiguration#magic_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "magicDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MagicDns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>nameservers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#nameservers DnsConfiguration#nameservers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameservers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationNameservers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nameservers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled, use the configured DNS servers in `nameservers` to resolve names outside the tailnet.</summary>
            /// <remarks>
            /// When disabled, devices will prefer their local DNS configuration. Defaults to false.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#override_local_dns DnsConfiguration#override_local_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideLocalDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OverrideLocalDns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Additional search domains. When MagicDNS is on, the tailnet domain is automatically included as the first search domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#search_paths DnsConfiguration#search_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SearchPaths
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>split_dns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#split_dns DnsConfiguration#split_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "splitDns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationSplitDns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SplitDns
            {
                get => GetInstanceProperty<object?>();
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
