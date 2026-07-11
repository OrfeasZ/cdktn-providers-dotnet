using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesOutputReference), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GroupRoleManagementPolicyNotificationRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GroupRoleManagementPolicyNotificationRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GroupRoleManagementPolicyNotificationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyNotificationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveAssignments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments\"}}]")]
        public virtual void PutActiveAssignments(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEligibleActivations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations\"}}]")]
        public virtual void PutEligibleActivations(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEligibleAssignments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignments\"}}]")]
        public virtual void PutEligibleAssignments(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveAssignments")]
        public virtual void ResetActiveAssignments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEligibleActivations")]
        public virtual void ResetEligibleActivations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEligibleAssignments")]
        public virtual void ResetEligibleAssignments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference ActiveAssignments
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference>()!;
        }

        [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference EligibleActivations
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference>()!;
        }

        [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference EligibleAssignments
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeAssignmentsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignmentsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eligibleActivationsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivationsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eligibleAssignmentsInput", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignmentsInput
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRules\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules? InternalValue
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
