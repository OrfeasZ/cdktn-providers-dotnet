using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actionMembers", typeJson: "{\"fqn\":\"oci.dataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsActionMembersList\"}")]
        public virtual oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsActionMembersList ActionMembers
        {
            get => GetInstanceProperty<oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItemsActionMembersList>()!;
        }

        [JsiiProperty(name: "actionOrder", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActionOrder
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "actionParams", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ActionParams
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedTimeInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "schedulingWindowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingWindowId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseSchedulingPolicyRecommendedScheduledActions.DataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions.IDataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseSchedulingPolicyRecommendedScheduledActions.IDataOciDatabaseSchedulingPolicyRecommendedScheduledActionsRecommendedScheduledActionsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
