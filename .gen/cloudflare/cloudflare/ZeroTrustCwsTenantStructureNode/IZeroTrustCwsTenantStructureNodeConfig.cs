using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCwsTenantStructureNode
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCwsTenantStructureNodeConfig), fullyQualifiedName: "cloudflare.zeroTrustCwsTenantStructureNode.ZeroTrustCwsTenantStructureNodeConfig")]
    public interface IZeroTrustCwsTenantStructureNodeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Cloudflare account ID (32-character hexadecimal string).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#account_id ZeroTrustCwsTenantStructureNode#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Cloud-native identifier of this node, unique within the structure;</summary>
        /// <remarks>
        /// the parent-reference target. Shape depends on the structure's application. Immutable after create.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#native_id ZeroTrustCwsTenantStructureNode#native_id}
        /// </remarks>
        [JsiiProperty(name: "nativeId", typeJson: "{\"primitive\":\"string\"}")]
        string NativeId
        {
            get;
        }

        /// <summary>Position in the tree.</summary>
        /// <remarks>
        /// Legal values depend on the structure's application (aws: root/ou/account; cloudflare: org/account/zone). At most one root per structure. Immutable after create.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#node_kind ZeroTrustCwsTenantStructureNode#node_kind}
        /// </remarks>
        [JsiiProperty(name: "nodeKind", typeJson: "{\"primitive\":\"string\"}")]
        string NodeKind
        {
            get;
        }

        /// <summary>ID of the parent tenant structure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#structure_id ZeroTrustCwsTenantStructureNode#structure_id}
        /// </remarks>
        [JsiiProperty(name: "structureId", typeJson: "{\"primitive\":\"string\"}")]
        string StructureId
        {
            get;
        }

        /// <summary>Display name (e.g. an OU or account name), mutable. Optional; empty by default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#name ZeroTrustCwsTenantStructureNode#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Native ID of this node's parent.</summary>
        /// <remarks>
        /// Required for non-root nodes and omitted for the root. The parent must be in the same structure and able to contain this node kind.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#parent ZeroTrustCwsTenantStructureNode#parent}
        /// </remarks>
        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCwsTenantStructureNodeConfig), fullyQualifiedName: "cloudflare.zeroTrustCwsTenantStructureNode.ZeroTrustCwsTenantStructureNodeConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCwsTenantStructureNode.IZeroTrustCwsTenantStructureNodeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloudflare account ID (32-character hexadecimal string).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#account_id ZeroTrustCwsTenantStructureNode#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Cloud-native identifier of this node, unique within the structure;</summary>
            /// <remarks>
            /// the parent-reference target. Shape depends on the structure's application. Immutable after create.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#native_id ZeroTrustCwsTenantStructureNode#native_id}
            /// </remarks>
            [JsiiProperty(name: "nativeId", typeJson: "{\"primitive\":\"string\"}")]
            public string NativeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Position in the tree.</summary>
            /// <remarks>
            /// Legal values depend on the structure's application (aws: root/ou/account; cloudflare: org/account/zone). At most one root per structure. Immutable after create.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#node_kind ZeroTrustCwsTenantStructureNode#node_kind}
            /// </remarks>
            [JsiiProperty(name: "nodeKind", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeKind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the parent tenant structure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#structure_id ZeroTrustCwsTenantStructureNode#structure_id}
            /// </remarks>
            [JsiiProperty(name: "structureId", typeJson: "{\"primitive\":\"string\"}")]
            public string StructureId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Display name (e.g. an OU or account name), mutable. Optional; empty by default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#name ZeroTrustCwsTenantStructureNode#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Native ID of this node's parent.</summary>
            /// <remarks>
            /// Required for non-root nodes and omitted for the root. The parent must be in the same structure and able to contain this node kind.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_tenant_structure_node#parent ZeroTrustCwsTenantStructureNode#parent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parent
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
