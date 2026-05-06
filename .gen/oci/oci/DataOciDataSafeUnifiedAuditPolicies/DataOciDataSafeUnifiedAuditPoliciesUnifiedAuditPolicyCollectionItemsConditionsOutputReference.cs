using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUnifiedAuditPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeUnifiedAuditPolicies.DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeUnifiedAuditPolicies.DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attributeSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitySelection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySelection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RoleNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeUnifiedAuditPolicies.DataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditions\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeUnifiedAuditPolicies.IDataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeUnifiedAuditPolicies.IDataOciDataSafeUnifiedAuditPoliciesUnifiedAuditPolicyCollectionItemsConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
