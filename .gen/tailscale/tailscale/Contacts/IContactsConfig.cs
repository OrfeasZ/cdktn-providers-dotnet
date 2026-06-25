using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Contacts
{
    [JsiiInterface(nativeType: typeof(IContactsConfig), fullyQualifiedName: "tailscale.contacts.ContactsConfig")]
    public interface IContactsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#account Contacts#account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsAccount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "account", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Account
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#security Contacts#security}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsSecurity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsSecurity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>support block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#support Contacts#support}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsSupport" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "support", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsSupport\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Support
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContactsConfig), fullyQualifiedName: "tailscale.contacts.ContactsConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.Contacts.IContactsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#account Contacts#account}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsAccount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "account", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Account
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#security Contacts#security}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsSecurity" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsSecurity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Security
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>support block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#support Contacts#support}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.Contacts.IContactsSupport" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "support", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.contacts.ContactsSupport\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Support
            {
                get => GetInstanceProperty<object?>();
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
