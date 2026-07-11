using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications")]
    public interface IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications
    {
        /// <summary>Whether the default recipients are notified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#default_recipients GroupRoleManagementPolicy#default_recipients}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DefaultRecipients
        {
            get;
        }

        /// <summary>What level of notifications are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#notification_level GroupRoleManagementPolicy#notification_level}
        /// </remarks>
        [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
        string NotificationLevel
        {
            get;
        }

        /// <summary>The additional recipients to notify.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#additional_recipients GroupRoleManagementPolicy#additional_recipients}
        /// </remarks>
        [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalRecipients
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the default recipients are notified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#default_recipients GroupRoleManagementPolicy#default_recipients}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DefaultRecipients
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>What level of notifications are sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#notification_level GroupRoleManagementPolicy#notification_level}
            /// </remarks>
            [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string NotificationLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The additional recipients to notify.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#additional_recipients GroupRoleManagementPolicy#additional_recipients}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalRecipients
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
