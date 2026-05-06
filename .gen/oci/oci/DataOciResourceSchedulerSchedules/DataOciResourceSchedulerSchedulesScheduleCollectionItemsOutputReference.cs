using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciResourceSchedulerSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciResourceSchedulerSchedulesScheduleCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastRunStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRunStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recurrenceDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurrenceDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurrenceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceFilters", typeJson: "{\"fqn\":\"oci.dataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourceFiltersList\"}")]
        public virtual oci.DataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourceFiltersList ResourceFilters
        {
            get => GetInstanceProperty<oci.DataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourceFiltersList>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"oci.dataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourcesList\"}")]
        public virtual oci.DataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourcesList Resources
        {
            get => GetInstanceProperty<oci.DataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItemsResourcesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNextRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNextRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarts
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciResourceSchedulerSchedules.DataOciResourceSchedulerSchedulesScheduleCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciResourceSchedulerSchedules.IDataOciResourceSchedulerSchedulesScheduleCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciResourceSchedulerSchedules.IDataOciResourceSchedulerSchedulesScheduleCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
