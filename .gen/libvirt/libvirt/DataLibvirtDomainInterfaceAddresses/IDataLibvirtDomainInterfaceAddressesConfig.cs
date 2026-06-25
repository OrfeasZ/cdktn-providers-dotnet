using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.DataLibvirtDomainInterfaceAddresses
{
    [JsiiInterface(nativeType: typeof(IDataLibvirtDomainInterfaceAddressesConfig), fullyQualifiedName: "libvirt.dataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesConfig")]
    public interface IDataLibvirtDomainInterfaceAddressesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Domain UUID or name to query. Use `libvirt_domain.example.id` or `libvirt_domain.example.name` to reference a managed domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/domain_interface_addresses#domain DataLibvirtDomainInterfaceAddresses#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>Source to query for IP addresses: - `lease` - Query DHCP server leases (fast, no guest agent needed) - `agent` - Query QEMU guest agent (requires qemu-guest-agent installed in guest) - `any` - Try both sources (default)  If not specified, attempts both sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/domain_interface_addresses#source DataLibvirtDomainInterfaceAddresses#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLibvirtDomainInterfaceAddressesConfig), fullyQualifiedName: "libvirt.dataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.DataLibvirtDomainInterfaceAddresses.IDataLibvirtDomainInterfaceAddressesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Domain UUID or name to query. Use `libvirt_domain.example.id` or `libvirt_domain.example.name` to reference a managed domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/domain_interface_addresses#domain DataLibvirtDomainInterfaceAddresses#domain}
            /// </remarks>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Source to query for IP addresses: - `lease` - Query DHCP server leases (fast, no guest agent needed) - `agent` - Query QEMU guest agent (requires qemu-guest-agent installed in guest) - `any` - Try both sources (default)  If not specified, attempts both sources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/domain_interface_addresses#source DataLibvirtDomainInterfaceAddresses#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
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
