using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DlsPrefixBinding
{
    [JsiiInterface(nativeType: typeof(IDlsPrefixBindingConfig), fullyQualifiedName: "cloudflare.dlsPrefixBinding.DlsPrefixBindingConfig")]
    public interface IDlsPrefixBindingConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier of a Cloudflare account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#account_id DlsPrefixBinding#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>IP prefix in CIDR notation to bind.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#cidr DlsPrefixBinding#cidr}
        /// </remarks>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        string Cidr
        {
            get;
        }

        /// <summary>The ID of the parent IP prefix that contains the CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#prefix_id DlsPrefixBinding#prefix_id}
        /// </remarks>
        [JsiiProperty(name: "prefixId", typeJson: "{\"primitive\":\"string\"}")]
        string PrefixId
        {
            get;
        }

        /// <summary>Region key from managed regions (e.g., "us", "eu").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#region_key DlsPrefixBinding#region_key}
        /// </remarks>
        [JsiiProperty(name: "regionKey", typeJson: "{\"primitive\":\"string\"}")]
        string RegionKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlsPrefixBindingConfig), fullyQualifiedName: "cloudflare.dlsPrefixBinding.DlsPrefixBindingConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DlsPrefixBinding.IDlsPrefixBindingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier of a Cloudflare account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#account_id DlsPrefixBinding#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IP prefix in CIDR notation to bind.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#cidr DlsPrefixBinding#cidr}
            /// </remarks>
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
            public string Cidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the parent IP prefix that contains the CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#prefix_id DlsPrefixBinding#prefix_id}
            /// </remarks>
            [JsiiProperty(name: "prefixId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrefixId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Region key from managed regions (e.g., "us", "eu").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/dls_prefix_binding#region_key DlsPrefixBinding#region_key}
            /// </remarks>
            [JsiiProperty(name: "regionKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionKey
            {
                get => GetInstanceProperty<string>()!;
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
