using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}}]")]
        public virtual void PutAdminNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApproverNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}}]")]
        public virtual void PutApproverNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssigneeNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}}]")]
        public virtual void PutAssigneeNotifications(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications)}, new object[]{@value});
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

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference AdminNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference ApproverNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference AssigneeNotifications
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications? AdminNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotificationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotificationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments? InternalValue
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments?>();
            set => SetInstanceProperty(value);
        }
    }
}
