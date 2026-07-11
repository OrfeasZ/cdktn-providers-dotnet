using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}}]")]
        public virtual void PutAdminNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApproverNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}}]")]
        public virtual void PutApproverNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssigneeNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}}]")]
        public virtual void PutAssigneeNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminNotifications")]
        public virtual void ResetAdminNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApproverNotifications")]
        public virtual void ResetApproverNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAssigneeNotifications")]
        public virtual void ResetAssigneeNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference AdminNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference ApproverNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference AssigneeNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments? InternalValue
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments?>();
            set => SetInstanceProperty(value);
        }
    }
}
