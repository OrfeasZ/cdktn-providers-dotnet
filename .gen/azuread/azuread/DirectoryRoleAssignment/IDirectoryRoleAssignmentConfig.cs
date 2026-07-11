using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DirectoryRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IDirectoryRoleAssignmentConfig), fullyQualifiedName: "azuread.directoryRoleAssignment.DirectoryRoleAssignmentConfig")]
    public interface IDirectoryRoleAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The object ID of the member principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#principal_object_id DirectoryRoleAssignment#principal_object_id}
        /// </remarks>
        [JsiiProperty(name: "principalObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalObjectId
        {
            get;
        }

        /// <summary>The object ID of the directory role for this assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#role_id DirectoryRoleAssignment#role_id}
        /// </remarks>
        [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleId
        {
            get;
        }

        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#app_scope_id DirectoryRoleAssignment#app_scope_id}
        /// </remarks>
        [JsiiProperty(name: "appScopeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppScopeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the directory object representing the scope of the assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#directory_scope_id DirectoryRoleAssignment#directory_scope_id}
        /// </remarks>
        [JsiiProperty(name: "directoryScopeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryScopeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#id DirectoryRoleAssignment#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#timeouts DirectoryRoleAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.directoryRoleAssignment.DirectoryRoleAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.DirectoryRoleAssignment.IDirectoryRoleAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryRoleAssignmentConfig), fullyQualifiedName: "azuread.directoryRoleAssignment.DirectoryRoleAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.DirectoryRoleAssignment.IDirectoryRoleAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The object ID of the member principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#principal_object_id DirectoryRoleAssignment#principal_object_id}
            /// </remarks>
            [JsiiProperty(name: "principalObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the directory role for this assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#role_id DirectoryRoleAssignment#role_id}
            /// </remarks>
            [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#app_scope_id DirectoryRoleAssignment#app_scope_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appScopeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppScopeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the directory object representing the scope of the assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#directory_scope_id DirectoryRoleAssignment#directory_scope_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directoryScopeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryScopeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#id DirectoryRoleAssignment#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_assignment#timeouts DirectoryRoleAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.directoryRoleAssignment.DirectoryRoleAssignmentTimeouts\"}", isOptional: true)]
            public azuread.DirectoryRoleAssignment.IDirectoryRoleAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.DirectoryRoleAssignment.IDirectoryRoleAssignmentTimeouts?>();
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
