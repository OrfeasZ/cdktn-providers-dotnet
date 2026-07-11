using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationPermissionScope
{
    [JsiiInterface(nativeType: typeof(IApplicationPermissionScopeConfig), fullyQualifiedName: "azuread.applicationPermissionScope.ApplicationPermissionScopeConfig")]
    public interface IApplicationPermissionScopeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#admin_consent_description ApplicationPermissionScope#admin_consent_description}
        /// </remarks>
        [JsiiProperty(name: "adminConsentDescription", typeJson: "{\"primitive\":\"string\"}")]
        string AdminConsentDescription
        {
            get;
        }

        /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#admin_consent_display_name ApplicationPermissionScope#admin_consent_display_name}
        /// </remarks>
        [JsiiProperty(name: "adminConsentDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        string AdminConsentDisplayName
        {
            get;
        }

        /// <summary>The resource ID of the application to which this permission scope should be applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#application_id ApplicationPermissionScope#application_id}
        /// </remarks>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>The unique identifier of the permission scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#scope_id ApplicationPermissionScope#scope_id}
        /// </remarks>
        [JsiiProperty(name: "scopeId", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeId
        {
            get;
        }

        /// <summary>The value that is used for the `scp` claim in OAuth access tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#value ApplicationPermissionScope#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#id ApplicationPermissionScope#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#timeouts ApplicationPermissionScope#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationPermissionScope.ApplicationPermissionScopeTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ApplicationPermissionScope.IApplicationPermissionScopeTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#type ApplicationPermissionScope#type}
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

        /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#user_consent_description ApplicationPermissionScope#user_consent_description}
        /// </remarks>
        [JsiiProperty(name: "userConsentDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserConsentDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Display name for the delegated permission that appears in the end user consent experience.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#user_consent_display_name ApplicationPermissionScope#user_consent_display_name}
        /// </remarks>
        [JsiiProperty(name: "userConsentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserConsentDisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationPermissionScopeConfig), fullyQualifiedName: "azuread.applicationPermissionScope.ApplicationPermissionScopeConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ApplicationPermissionScope.IApplicationPermissionScopeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#admin_consent_description ApplicationPermissionScope#admin_consent_description}
            /// </remarks>
            [JsiiProperty(name: "adminConsentDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminConsentDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#admin_consent_display_name ApplicationPermissionScope#admin_consent_display_name}
            /// </remarks>
            [JsiiProperty(name: "adminConsentDisplayName", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminConsentDisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The resource ID of the application to which this permission scope should be applied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#application_id ApplicationPermissionScope#application_id}
            /// </remarks>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique identifier of the permission scope.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#scope_id ApplicationPermissionScope#scope_id}
            /// </remarks>
            [JsiiProperty(name: "scopeId", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value that is used for the `scp` claim in OAuth access tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#value ApplicationPermissionScope#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#id ApplicationPermissionScope#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#timeouts ApplicationPermissionScope#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationPermissionScope.ApplicationPermissionScopeTimeouts\"}", isOptional: true)]
            public azuread.ApplicationPermissionScope.IApplicationPermissionScopeTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ApplicationPermissionScope.IApplicationPermissionScopeTimeouts?>();
            }

            /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#type ApplicationPermissionScope#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#user_consent_description ApplicationPermissionScope#user_consent_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userConsentDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserConsentDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Display name for the delegated permission that appears in the end user consent experience.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_permission_scope#user_consent_display_name ApplicationPermissionScope#user_consent_display_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userConsentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserConsentDisplayName
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
