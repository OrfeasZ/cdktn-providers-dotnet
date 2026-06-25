using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailSecurityImpersonationRegistry
{
    [JsiiInterface(nativeType: typeof(IEmailSecurityImpersonationRegistryConfig), fullyQualifiedName: "cloudflare.emailSecurityImpersonationRegistry.EmailSecurityImpersonationRegistryConfig")]
    public interface IEmailSecurityImpersonationRegistryConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#account_id EmailSecurityImpersonationRegistry#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#email EmailSecurityImpersonationRegistry#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#is_email_regex EmailSecurityImpersonationRegistry#is_email_regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEmailRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEmailRegex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#name EmailSecurityImpersonationRegistry#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#comments EmailSecurityImpersonationRegistry#comments}.</summary>
        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#directory_id EmailSecurityImpersonationRegistry#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DirectoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#directory_node_id EmailSecurityImpersonationRegistry#directory_node_id}.</summary>
        [JsiiProperty(name: "directoryNodeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DirectoryNodeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#external_directory_node_id EmailSecurityImpersonationRegistry#external_directory_node_id}.</summary>
        [JsiiProperty(name: "externalDirectoryNodeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalDirectoryNodeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "A1S_INTERNAL", "SNOOPY-CASB_OFFICE_365", "SNOOPY-OFFICE_365", "SNOOPY-GOOGLE_DIRECTORY".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#provenance EmailSecurityImpersonationRegistry#provenance}
        /// </remarks>
        [JsiiProperty(name: "provenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Provenance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailSecurityImpersonationRegistryConfig), fullyQualifiedName: "cloudflare.emailSecurityImpersonationRegistry.EmailSecurityImpersonationRegistryConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailSecurityImpersonationRegistry.IEmailSecurityImpersonationRegistryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#account_id EmailSecurityImpersonationRegistry#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#email EmailSecurityImpersonationRegistry#email}.</summary>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#is_email_regex EmailSecurityImpersonationRegistry#is_email_regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isEmailRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEmailRegex
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#name EmailSecurityImpersonationRegistry#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#comments EmailSecurityImpersonationRegistry#comments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comments
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#directory_id EmailSecurityImpersonationRegistry#directory_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DirectoryId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#directory_node_id EmailSecurityImpersonationRegistry#directory_node_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryNodeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DirectoryNodeId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#external_directory_node_id EmailSecurityImpersonationRegistry#external_directory_node_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalDirectoryNodeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalDirectoryNodeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "A1S_INTERNAL", "SNOOPY-CASB_OFFICE_365", "SNOOPY-OFFICE_365", "SNOOPY-GOOGLE_DIRECTORY".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/email_security_impersonation_registry#provenance EmailSecurityImpersonationRegistry#provenance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Provenance
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
