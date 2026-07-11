using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GroupRoleManagementPolicyActivationRulesApprovalStageOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover" />)[]</param>
        [JsiiMethod(name: "putPrimaryApprover", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrimaryApprover(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "primaryApprover", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApproverList\"}")]
        public virtual azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApproverList PrimaryApprover
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApproverList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryApproverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrimaryApproverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage\"}", isOptional: true)]
        public virtual azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage? InternalValue
        {
            get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage?>();
            set => SetInstanceProperty(value);
        }
    }
}
