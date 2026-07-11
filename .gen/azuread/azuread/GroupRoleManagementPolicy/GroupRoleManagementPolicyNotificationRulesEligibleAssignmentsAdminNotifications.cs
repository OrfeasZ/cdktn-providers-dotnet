using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications")]
    public class GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications
    {
        private object _defaultRecipients;

        /// <summary>Whether the default recipients are notified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#default_recipients GroupRoleManagementPolicy#default_recipients}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object DefaultRecipients
        {
            get => _defaultRecipients;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultRecipients = value;
            }
        }

        /// <summary>What level of notifications are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#notification_level GroupRoleManagementPolicy#notification_level}
        /// </remarks>
        [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string NotificationLevel
        {
            get;
            set;
        }

        /// <summary>The additional recipients to notify.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#additional_recipients GroupRoleManagementPolicy#additional_recipients}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalRecipients
        {
            get;
            set;
        }
    }
}
