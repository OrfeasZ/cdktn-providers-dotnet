using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DataTailscaleUsers
{
    [JsiiInterface(nativeType: typeof(IDataTailscaleUsersConfig), fullyQualifiedName: "tailscale.dataTailscaleUsers.DataTailscaleUsersConfig")]
    public interface IDataTailscaleUsersConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Filter the results to only include users with a specific role.</summary>
        /// <remarks>
        /// Valid values are <c>owner</c>, <c>member</c>, <c>admin</c>, <c>it-admin</c>, <c>network-admin</c>, <c>billing-admin</c>, and <c>auditor</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#role DataTailscaleUsers#role}
        /// </remarks>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter the results to only include users of a specific type. Valid values are `member` or `shared`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#type DataTailscaleUsers#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#users DataTailscaleUsers#users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.DataTailscaleUsers.IDataTailscaleUsersUsers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "users", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dataTailscaleUsers.DataTailscaleUsersUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Users
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataTailscaleUsersConfig), fullyQualifiedName: "tailscale.dataTailscaleUsers.DataTailscaleUsersConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.DataTailscaleUsers.IDataTailscaleUsersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter the results to only include users with a specific role.</summary>
            /// <remarks>
            /// Valid values are <c>owner</c>, <c>member</c>, <c>admin</c>, <c>it-admin</c>, <c>network-admin</c>, <c>billing-admin</c>, and <c>auditor</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#role DataTailscaleUsers#role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the results to only include users of a specific type. Valid values are `member` or `shared`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#type DataTailscaleUsers#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/users#users DataTailscaleUsers#users}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.DataTailscaleUsers.IDataTailscaleUsersUsers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "users", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dataTailscaleUsers.DataTailscaleUsersUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Users
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
