using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject
{
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approximateRowCountBeforeSubsetting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproximateRowCountBeforeSubsetting
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "childObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildObjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "childSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildSchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedRowCountAfterSubsetting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedRowCountAfterSubsetting
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnabledForProcessing", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabledForProcessing
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ParentColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "parentObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentObjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentSchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "propagationImpact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagationImpact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingSchemaRelationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingSchemaRelationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItems\"}", isOptional: true)]
        public virtual oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
