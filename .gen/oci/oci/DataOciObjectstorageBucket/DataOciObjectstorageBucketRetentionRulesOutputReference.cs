using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciObjectstorageBucket
{
    [JsiiClass(nativeType: typeof(oci.DataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRulesOutputReference), fullyQualifiedName: "oci.dataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciObjectstorageBucketRetentionRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciObjectstorageBucketRetentionRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciObjectstorageBucketRetentionRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciObjectstorageBucketRetentionRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"oci.dataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRulesDurationList\"}")]
        public virtual oci.DataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRulesDurationList Duration
        {
            get => GetInstanceProperty<oci.DataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRulesDurationList>()!;
        }

        [JsiiProperty(name: "retentionRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionRuleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRuleLocked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRuleLocked
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciObjectstorageBucket.DataOciObjectstorageBucketRetentionRules\"}", isOptional: true)]
        public virtual oci.DataOciObjectstorageBucket.IDataOciObjectstorageBucketRetentionRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciObjectstorageBucket.IDataOciObjectstorageBucketRetentionRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
