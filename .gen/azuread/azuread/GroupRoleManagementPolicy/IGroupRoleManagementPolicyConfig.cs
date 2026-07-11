using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyConfig), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyConfig")]
    public interface IGroupRoleManagementPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the group to which this policy is assigned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#group_id GroupRoleManagementPolicy#group_id}
        /// </remarks>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>The ID of the role of this policy to the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#role_id GroupRoleManagementPolicy#role_id}
        /// </remarks>
        [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleId
        {
            get;
        }

        /// <summary>activation_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#activation_rules GroupRoleManagementPolicy#activation_rules}
        /// </remarks>
        [JsiiProperty(name: "activationRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRules? ActivationRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>active_assignment_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#active_assignment_rules GroupRoleManagementPolicy#active_assignment_rules}
        /// </remarks>
        [JsiiProperty(name: "activeAssignmentRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActiveAssignmentRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActiveAssignmentRules? ActiveAssignmentRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>eligible_assignment_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#eligible_assignment_rules GroupRoleManagementPolicy#eligible_assignment_rules}
        /// </remarks>
        [JsiiProperty(name: "eligibleAssignmentRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyEligibleAssignmentRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyEligibleAssignmentRules? EligibleAssignmentRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#id GroupRoleManagementPolicy#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#notification_rules GroupRoleManagementPolicy#notification_rules}
        /// </remarks>
        [JsiiProperty(name: "notificationRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules? NotificationRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#timeouts GroupRoleManagementPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyConfig), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the group to which this policy is assigned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#group_id GroupRoleManagementPolicy#group_id}
            /// </remarks>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the role of this policy to the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#role_id GroupRoleManagementPolicy#role_id}
            /// </remarks>
            [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>activation_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#activation_rules GroupRoleManagementPolicy#activation_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activationRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRules\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRules? ActivationRules
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRules?>();
            }

            /// <summary>active_assignment_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#active_assignment_rules GroupRoleManagementPolicy#active_assignment_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeAssignmentRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActiveAssignmentRules\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActiveAssignmentRules? ActiveAssignmentRules
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActiveAssignmentRules?>();
            }

            /// <summary>eligible_assignment_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#eligible_assignment_rules GroupRoleManagementPolicy#eligible_assignment_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eligibleAssignmentRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyEligibleAssignmentRules\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyEligibleAssignmentRules? EligibleAssignmentRules
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyEligibleAssignmentRules?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#id GroupRoleManagementPolicy#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#notification_rules GroupRoleManagementPolicy#notification_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationRules", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRules\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules? NotificationRules
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#timeouts GroupRoleManagementPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyTimeouts\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyTimeouts?>();
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
