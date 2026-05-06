using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFusionAppsFusionEnvironmentRefreshActivities
{
    [JsiiClass(nativeType: typeof(oci.DataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDataMaskingOpted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDataMaskingOpted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshActivityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshActivityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshIssueDetailsList", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsRefreshIssueDetailsListStructList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsRefreshIssueDetailsListStructList RefreshIssueDetailsList
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItemsRefreshIssueDetailsListStructList>()!;
        }

        [JsiiProperty(name: "serviceAvailability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAvailability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceFusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceFusionEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpectedFinish", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpectedFinish
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfRestorationPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfRestorationPoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentRefreshActivities.DataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFusionAppsFusionEnvironmentRefreshActivities.IDataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentRefreshActivities.IDataOciFusionAppsFusionEnvironmentRefreshActivitiesRefreshActivityCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
