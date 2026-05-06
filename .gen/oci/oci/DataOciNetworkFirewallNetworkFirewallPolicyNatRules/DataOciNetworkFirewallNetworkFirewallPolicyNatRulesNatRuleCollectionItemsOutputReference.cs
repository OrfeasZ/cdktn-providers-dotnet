using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules
{
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsConditionList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsConditionList Condition
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsConditionList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsPositionList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsPositionList Position
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItemsPositionList>()!;
        }

        [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityOrder
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyNatRules.DataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.IDataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyNatRules.IDataOciNetworkFirewallNetworkFirewallPolicyNatRulesNatRuleCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
