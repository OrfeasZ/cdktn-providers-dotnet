using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsSplitNameservers
{
    [JsiiInterface(nativeType: typeof(IDnsSplitNameserversConfig), fullyQualifiedName: "tailscale.dnsSplitNameservers.DnsSplitNameserversConfig")]
    public interface IDnsSplitNameserversConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Domain to configure split DNS for.</summary>
        /// <remarks>
        /// Requests for this domain will be resolved using the provided nameservers. Changing this will force the resource to be recreated.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_split_nameservers#domain DnsSplitNameservers#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>Devices on your network will use these nameservers to resolve DNS names. IPv4 or IPv6 addresses are accepted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_split_nameservers#nameservers DnsSplitNameservers#nameservers}
        /// </remarks>
        [JsiiProperty(name: "nameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Nameservers
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsSplitNameserversConfig), fullyQualifiedName: "tailscale.dnsSplitNameservers.DnsSplitNameserversConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.DnsSplitNameservers.IDnsSplitNameserversConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Domain to configure split DNS for.</summary>
            /// <remarks>
            /// Requests for this domain will be resolved using the provided nameservers. Changing this will force the resource to be recreated.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_split_nameservers#domain DnsSplitNameservers#domain}
            /// </remarks>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Devices on your network will use these nameservers to resolve DNS names. IPv4 or IPv6 addresses are accepted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_split_nameservers#nameservers DnsSplitNameservers#nameservers}
            /// </remarks>
            [JsiiProperty(name: "nameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Nameservers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
