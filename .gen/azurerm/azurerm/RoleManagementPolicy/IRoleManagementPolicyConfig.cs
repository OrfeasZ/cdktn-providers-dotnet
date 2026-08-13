using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyConfig), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyConfig")]
    public interface IRoleManagementPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the Azure Role to which this policy is assigned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#role_definition_id RoleManagementPolicy#role_definition_id}
        /// </remarks>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleDefinitionId
        {
            get;
        }

        /// <summary>The scope of the role to which this policy will apply.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#scope RoleManagementPolicy#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>activation_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#activation_rules RoleManagementPolicy#activation_rules}
        /// </remarks>
        [JsiiProperty(name: "activationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules? ActivationRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>active_assignment_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#active_assignment_rules RoleManagementPolicy#active_assignment_rules}
        /// </remarks>
        [JsiiProperty(name: "activeAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules? ActiveAssignmentRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>eligible_assignment_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#eligible_assignment_rules RoleManagementPolicy#eligible_assignment_rules}
        /// </remarks>
        [JsiiProperty(name: "eligibleAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules? EligibleAssignmentRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#id RoleManagementPolicy#id}.</summary>
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

        /// <summary>notification_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#notification_rules RoleManagementPolicy#notification_rules}
        /// </remarks>
        [JsiiProperty(name: "notificationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules? NotificationRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#timeouts RoleManagementPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RoleManagementPolicy.IRoleManagementPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyConfig), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Azure Role to which this policy is assigned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#role_definition_id RoleManagementPolicy#role_definition_id}
            /// </remarks>
            [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The scope of the role to which this policy will apply.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#scope RoleManagementPolicy#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>activation_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#activation_rules RoleManagementPolicy#activation_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules? ActivationRules
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules?>();
            }

            /// <summary>active_assignment_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#active_assignment_rules RoleManagementPolicy#active_assignment_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules? ActiveAssignmentRules
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules?>();
            }

            /// <summary>eligible_assignment_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#eligible_assignment_rules RoleManagementPolicy#eligible_assignment_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eligibleAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules? EligibleAssignmentRules
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#id RoleManagementPolicy#id}.</summary>
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

            /// <summary>notification_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#notification_rules RoleManagementPolicy#notification_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules? NotificationRules
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/role_management_policy#timeouts RoleManagementPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyTimeouts\"}", isOptional: true)]
            public azurerm.RoleManagementPolicy.IRoleManagementPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyTimeouts?>();
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
