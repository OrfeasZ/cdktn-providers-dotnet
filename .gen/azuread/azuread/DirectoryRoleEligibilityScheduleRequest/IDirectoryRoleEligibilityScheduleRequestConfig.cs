using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DirectoryRoleEligibilityScheduleRequest
{
    [JsiiInterface(nativeType: typeof(IDirectoryRoleEligibilityScheduleRequestConfig), fullyQualifiedName: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestConfig")]
    public interface IDirectoryRoleEligibilityScheduleRequestConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier of the directory object representing the scope of the role eligibility schedule request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#directory_scope_id DirectoryRoleEligibilityScheduleRequest#directory_scope_id}
        /// </remarks>
        [JsiiProperty(name: "directoryScopeId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryScopeId
        {
            get;
        }

        /// <summary>Justification for why the role is assigned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#justification DirectoryRoleEligibilityScheduleRequest#justification}
        /// </remarks>
        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        string Justification
        {
            get;
        }

        /// <summary>The object ID of the member principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#principal_id DirectoryRoleEligibilityScheduleRequest#principal_id}
        /// </remarks>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        /// <summary>The object ID of the directory role for this role eligibility schedule request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#role_definition_id DirectoryRoleEligibilityScheduleRequest#role_definition_id}
        /// </remarks>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#id DirectoryRoleEligibilityScheduleRequest#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#timeouts DirectoryRoleEligibilityScheduleRequest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryRoleEligibilityScheduleRequestConfig), fullyQualifiedName: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier of the directory object representing the scope of the role eligibility schedule request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#directory_scope_id DirectoryRoleEligibilityScheduleRequest#directory_scope_id}
            /// </remarks>
            [JsiiProperty(name: "directoryScopeId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryScopeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Justification for why the role is assigned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#justification DirectoryRoleEligibilityScheduleRequest#justification}
            /// </remarks>
            [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
            public string Justification
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the member principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#principal_id DirectoryRoleEligibilityScheduleRequest#principal_id}
            /// </remarks>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the directory role for this role eligibility schedule request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#role_definition_id DirectoryRoleEligibilityScheduleRequest#role_definition_id}
            /// </remarks>
            [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#id DirectoryRoleEligibilityScheduleRequest#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#timeouts DirectoryRoleEligibilityScheduleRequest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts\"}", isOptional: true)]
            public azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts?>();
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
