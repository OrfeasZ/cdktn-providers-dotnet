using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMeteringComputationSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMeteringComputationSchedulesScheduleCollectionItemsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputFileFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputFileFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryProperties", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesList\"}")]
        public virtual oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesList QueryProperties
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsQueryPropertiesList>()!;
        }

        [JsiiProperty(name: "resultLocation", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsResultLocationList\"}")]
        public virtual oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsResultLocationList ResultLocation
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItemsResultLocationList>()!;
        }

        [JsiiProperty(name: "savedReportId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavedReportId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleRecurrences", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleRecurrences
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeNextRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNextRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMeteringComputationSchedules.DataOciMeteringComputationSchedulesScheduleCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMeteringComputationSchedules.IDataOciMeteringComputationSchedulesScheduleCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMeteringComputationSchedules.IDataOciMeteringComputationSchedulesScheduleCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
