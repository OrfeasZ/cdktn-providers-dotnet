using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRulesOutputReference), fullyQualifiedName: "azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermRoleManagementPolicyActivationRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermRoleManagementPolicyActivationRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRoleManagementPolicyActivationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRoleManagementPolicyActivationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalStage", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRulesApprovalStageList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRulesApprovalStageList ApprovalStage
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRulesApprovalStageList>()!;
        }

        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireApproval", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireApproval
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "requiredConditionalAccessAuthenticationContext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequiredConditionalAccessAuthenticationContext
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireJustification", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireJustification
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireMultifactorAuthentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "requireTicketInfo", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireTicketInfo
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyActivationRules\"}", isOptional: true)]
        public virtual azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyActivationRules? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyActivationRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
