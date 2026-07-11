using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}}]")]
        public virtual void PutAdminNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApproverNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}}]")]
        public virtual void PutApproverNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssigneeNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}}]")]
        public virtual void PutAssigneeNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications)}, new object[]{@value});
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

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsOutputReference AdminNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsOutputReference ApproverNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsOutputReference AssigneeNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations? InternalValue
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations?>();
            set => SetInstanceProperty(value);
        }
    }
}
