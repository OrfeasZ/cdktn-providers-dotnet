using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicySubsettingRules
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerTablesAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerTablesAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedTablesPropagation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelatedTablesPropagation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleCombinationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleCombinationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsScopeList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsScopeList Scope
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsScopeList>()!;
        }

        [JsiiProperty(name: "subsetRuleEntry", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsSubsetRuleEntryList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsSubsetRuleEntryList SubsetRuleEntry
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItemsSubsetRuleEntryList>()!;
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRules.DataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingRules.IDataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingRules.IDataOciDataSafeSubsettingPolicySubsettingRulesSubsettingRuleCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
