using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseWorkspaceSqlAadAdmin
{
    [JsiiInterface(nativeType: typeof(ISynapseWorkspaceSqlAadAdminConfig), fullyQualifiedName: "azurerm.synapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminConfig")]
    public interface ISynapseWorkspaceSqlAadAdminConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#login SynapseWorkspaceSqlAadAdmin#login}.</summary>
        [JsiiProperty(name: "login", typeJson: "{\"primitive\":\"string\"}")]
        string Login
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#object_id SynapseWorkspaceSqlAadAdmin#object_id}.</summary>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#synapse_workspace_id SynapseWorkspaceSqlAadAdmin#synapse_workspace_id}.</summary>
        [JsiiProperty(name: "synapseWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string SynapseWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#tenant_id SynapseWorkspaceSqlAadAdmin#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#id SynapseWorkspaceSqlAadAdmin#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#timeouts SynapseWorkspaceSqlAadAdmin#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseWorkspaceSqlAadAdmin.ISynapseWorkspaceSqlAadAdminTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseWorkspaceSqlAadAdminConfig), fullyQualifiedName: "azurerm.synapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseWorkspaceSqlAadAdmin.ISynapseWorkspaceSqlAadAdminConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#login SynapseWorkspaceSqlAadAdmin#login}.</summary>
            [JsiiProperty(name: "login", typeJson: "{\"primitive\":\"string\"}")]
            public string Login
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#object_id SynapseWorkspaceSqlAadAdmin#object_id}.</summary>
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#synapse_workspace_id SynapseWorkspaceSqlAadAdmin#synapse_workspace_id}.</summary>
            [JsiiProperty(name: "synapseWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SynapseWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#tenant_id SynapseWorkspaceSqlAadAdmin#tenant_id}.</summary>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#id SynapseWorkspaceSqlAadAdmin#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/synapse_workspace_sql_aad_admin#timeouts SynapseWorkspaceSqlAadAdmin#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminTimeouts\"}", isOptional: true)]
            public azurerm.SynapseWorkspaceSqlAadAdmin.ISynapseWorkspaceSqlAadAdminTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SynapseWorkspaceSqlAadAdmin.ISynapseWorkspaceSqlAadAdminTimeouts?>();
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
